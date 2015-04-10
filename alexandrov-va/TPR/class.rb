require 'matrix'

class Iterator

	attr_reader :matrix, :i_k, :j_k, :u_k, :v_k, :gamma1_k, :gamma2_k, :delta_k, :max_gamma2, :min_gamma1, :count

	def initialize(matrix)
		@matrix = matrix
		@i_k = []
		@j_k = []
		@u_k = []
		@v_k = []
		@gamma1_k = []
		@gamma2_k = []
		@delta_k = []
		@max_gamma2 = []
		@min_gamma1 = []
	end

	def calculate(i0, delta)

		i_k[0] = i0
		u_k[0] = matrix.row(i_k[0])
		gamma2_k[0] = u_k[0].min
		j_k[0] = u_k[0].to_a.index(gamma2_k[0])
		v_k[0] = matrix.column(j_k[0])
		gamma1_k[0] = v_k[0].max
		delta_k[0] = gamma1_k[0] - gamma2_k[0]

		min_gamma1[0] = gamma1_k[0]
		max_gamma2[0] = gamma2_k[0]

		i_k[1] = v_k[0].to_a.index(gamma1_k[0])

		i = 1
		while delta_k[i - 1] > delta do

			u_k[i] = matrix.row(i_k[i]) + u_k[i - 1]
			gamma2_k[i] = u_k[i].min / (i + 1)

			if gamma2_k[i] > max_gamma2[i - 1]
				max_gamma2[i] = gamma2_k[i]
			else
				max_gamma2[i] = max_gamma2[i - 1]
			end

			j_k[i] = u_k[i].to_a.index(u_k[i].min)
			v_k[i] = matrix.column(j_k[i]) + v_k[i - 1]
			gamma1_k[i] = v_k[i].max / (i + 1)

			if gamma1_k[i] < min_gamma1[i - 1]
				min_gamma1[i] = gamma1_k[i]
			else
				min_gamma1[i] = min_gamma1[i - 1]
			end

			delta_k[i] = min_gamma1[i] - max_gamma2[i]

			i_k[i + 1] = v_k[i].to_a.index(v_k[i].max)

			i += 1
		end

		@count = i
	end

	def do_print

		(0...count).each do |k|
			print "\nНомер итерации k: "
			p k

			print "Номер строки i: "
			p i_k[k]

			print "Строка U: "
			p u_k[k]

			print "Gamma2: "
			p gamma2_k[k]

			print "Max_Gamma2: "
			p max_gamma2[k]

			print "Номер столбца j: "
			p j_k[k]

			print "Столбец V: "
			p v_k[k]

			print "Gamma1: "
			p gamma1_k[k]

			print "Min_Gamma1: "
			p min_gamma1[k]

			print "Delta: "
			p delta_k[k]
		end

		puts "\nЦена игры: #{(min_gamma1[-1] + max_gamma2[-1])/2}"
	end
end

mas = []
IO.foreach("text.txt") do |line|
mas << line.split(' ')
end

mas.map!{|arr| arr.map{|elem| elem.to_f}}

0.upto(mas.size - 1) { |i| p mas[i] }

it1 = Iterator.new(Matrix[*mas])
it1.calculate(5, 1)
it1.do_print