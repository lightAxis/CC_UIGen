local current_file_path = string.sub(debug.getinfo(1).source, 2, string.len("/test1.lua") * -1)
local currentBinaryPath = io.open(current_file_path .. "/AbsPath.txt", "r")
local currentBinaryPath_str = currentBinaryPath:read("*a")
currentBinaryPath:close()
local path = currentBinaryPath_str .. "/" .. current_file_path .. "?.lua"
package.path = package.path .. ";".. path

local testclass = require("test2")

local params = {...}
local a = 0

while true do
	a = a + 1
	print(a)
	if a == 10 then break end
end

local aa = {}
table.insert(aa, "a0")
table.insert(aa, "b0")
table.insert(aa, "c0")
table.insert(aa, "d0")
table.insert(aa, "e0")
table.insert(aa, "f0")

local aa2 = {}
table.insert(aa2, "a1")
table.insert(aa2, "b1")
table.insert(aa2, "c1")
table.insert(aa2, "d1")
table.insert(aa2, "e1")
table.insert(aa2, "f1")

local aaa = {}
table.insert(aaa, aa)
table.insert(aaa, aa2)

--package.path = package.path .. ";"
return a + 100, current_file_path ,path, testclass:print__(), aaa