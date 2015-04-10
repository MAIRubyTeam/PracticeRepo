class Group
	attr_accessor :name, :users

	def initialize(name)
		@name = name
		@users = []
	end

end

class User

	attr_accessor :name

	def initialize(name)
		@name = name
		@groups = []
	end

	def groups
		@groups
	end

	def add_group(new_group)		
		if !(@groups.include?(new_group))
			@groups << new_group
			new_group.users.push(name)
		end
	end



end

admin = Group.new("admin")
user = Group.new("user")
moderator  = Group.new("moderator")

igor = User.new("Igor")
igor.add_group(admin)
igor.add_group(user)

aleksey = User.new("Aleksey")
aleksey.add_group(admin)
aleksey.add_group(admin)
aleksey.add_group(moderator)

p moderator.users