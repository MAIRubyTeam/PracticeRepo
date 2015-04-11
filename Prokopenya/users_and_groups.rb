$groups = []
$users = []

class Group
	attr_accessor :name

	def initialize(name)
		@name = name
		$groups.push(self)
	end

	def add_user(new_user)
		new_user.add_group(self)
	end	

end

class User

	attr_accessor :name

	def initialize(name)
		@name = name
		@groups = []
		$users.push(self)
	end

	def groups
		@groups
	end

	def add_group(new_group)		
		if !(@groups.include?(new_group))
			@groups << new_group
		end
	end



end

def group_hash(groups, users)

	hash = groups.inject(Hash.new{[]}){ |result, a|

	users.each do |elem| 
		if(elem.groups.include?(a))
			result[a.name] += [elem.name]
		end
	end
	result
	}

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


#p admin.users
#p user.users
#p moderator.users

p igor.groups
#p aleksey.groups

moderator.add_user(igor)

p group_hash($groups, $users)