require 'matrix'
require 'mathn'

class TwoSideGame

	attr_reader :payoff_matrix, :player1, :player2

	def initialize(payoff_matrix, player1, player2)

		@payoff_matrix = payoff_matrix
		@player1 = player1
		@player2 = player2
		@tracing = ""

	end

	def run_iterate(delta)

		i_k = []
		j_k = []
		u_k = []
		v_k = []
		gamma1_k = []
		gamma2_k = []
		delta_k = []
		max_gamma2 = []
		min_gamma1 = []

		i_k[0] = player1.strategy
		u_k[0] = payoff_matrix.row(i_k[0])
		gamma2_k[0] = player1.calculate_min(u_k[0])
		j_k[0] = player2.choose_strategy(u_k[0], gamma2_k[0])
		v_k[0] = payoff_matrix.column(player2.strategy)
		gamma1_k[0] = player2.calculate_max(v_k[0])
		delta_k[0] = gamma1_k[0] - gamma2_k[0]

		min_gamma1[0] = gamma1_k[0]
		max_gamma2[0] = gamma2_k[0]

		i = 0

		@tracing += "\nНомер итерации k: #{i}\n"
		@tracing += "Номер строки i: #{i_k[i]}\n"
		@tracing += "Строка U: #{u_k[i]}\n"
		@tracing += "Gamma2: #{gamma2_k[i]}\n"
		@tracing += "Max_Gamma2: #{max_gamma2[i]}\n"
		@tracing += "Номер столбца j: #{j_k[i]}\n"
		@tracing += "Столбец V: #{v_k[i]}\n"
		@tracing += "Gamma1: #{gamma1_k[i]}\n"
		@tracing += "Min_Gamma1: #{min_gamma1[i]}\n"
		@tracing += "Delta: #{delta_k[i]}\n"

		i = 1
		while delta_k[i - 1] > delta do

			i_k[i] = player1.choose_strategy(v_k[i - 1], gamma1_k[i - 1] * i)
			u_k[i] = payoff_matrix.row(player1.strategy) + u_k[i - 1]
			gamma2_k[i] = player1.calculate_min(u_k[i]) / (i + 1)

			if gamma2_k[i] > max_gamma2[i - 1]
				max_gamma2[i] = gamma2_k[i]
			else
				max_gamma2[i] = max_gamma2[i - 1]
			end

			j_k[i] = player2.choose_strategy(u_k[i], gamma2_k[i] * (i + 1))
			v_k[i] = payoff_matrix.column(player2.strategy) + v_k[i - 1]
			gamma1_k[i] = player2.calculate_max(v_k[i]) / (i + 1)

			if gamma1_k[i] < min_gamma1[i - 1]
				min_gamma1[i] = gamma1_k[i]
			else
				min_gamma1[i] = min_gamma1[i - 1]
			end

			delta_k[i] = min_gamma1[i] - max_gamma2[i]

			@tracing += "\nНомер итерации k: #{i}\n"
			@tracing += "Номер строки i: #{i_k[i]}\n"
			@tracing += "Строка U: #{u_k[i]}\n"
			@tracing += "Gamma2: #{gamma2_k[i]}\n"
			@tracing += "Max_Gamma2: #{max_gamma2[i]}\n"
			@tracing += "Номер столбца j: #{j_k[i]}\n"
			@tracing += "Столбец V: #{v_k[i]}\n"
			@tracing += "Gamma1: #{gamma1_k[i]}\n"
			@tracing += "Min_Gamma1: #{min_gamma1[i]}\n"
			@tracing += "Delta: #{delta_k[i]}\n"

			i += 1
		end

		@tracing += "\nЦена игры: #{(min_gamma1[-1] + max_gamma2[-1])/2}\n"

		s_a = Array.new(payoff_matrix.row_size){|index| i_k.find_all{|elem| elem == index}.size}
		s_b = Array.new(payoff_matrix.column_size){|index| j_k.find_all{|elem| elem == index}.size}

		s_a = Vector[*s_a] / i
		s_b = Vector[*s_b] / i

		@tracing += "Стратегии А: #{s_a.to_a}\n"
		@tracing += "Стратегии B: #{s_b.to_a}\n"

	end

	def to_s
		@tracing
	end

end

class Player

	attr_reader :strategy
	def initialize(start_position)

		@strategy = start_position;

	end

	def calculate_min(row)

		row.min

	end

	def calculate_max(col)

		col.max

	end

	def choose_strategy(vector, elem)

		@strategy = vector.to_a.index(elem)

	end

end

mas = []
IO.foreach("text.txt") do |line|
mas << line.split(' ')
end

mas.map!{|arr| arr.map{|elem| elem.to_f}}

ply1 = Player.new(5)
ply2 = Player.new(0)

game1 = TwoSideGame.new(Matrix[*mas], ply1, ply2)

game1.run_iterate(1)

puts game1