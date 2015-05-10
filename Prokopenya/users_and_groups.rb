class Group
	attr_accessor :name, :users

	def initialize(name)
		@name = name
		@users = []
	end

	def users
		@users
	end

	def add_user(new_user)
		if !(@users.include?(new_user))
			@users.push(new_user)
			new_user.add_group(self)
		end
	end	

	def to_s
		name + @users.inspect
	end
end

class User

	attr_accessor :name, :groups

	def initialize(name)
		@name = name
		@groups = []
	end

	def groups
		@groups
	end

	def add_group(new_group)		
		if !(@groups.include?(new_group))
			@groups.push(new_group)
			new_group.users.push(name)
		end
	end

	def to_s
		name + @groups.inspect
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

puts admin.to_s
puts igor.to_s