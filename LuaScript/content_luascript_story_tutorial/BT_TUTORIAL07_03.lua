Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

disableTextBox = true

function Load()
	demo_setup_nofade()

end

-- エネミーフェイズ1
function Play()
	Play_start(false)

	--バルバロイ移動
	unit_command_skill(2000001, 5, 4, 6, 4, 0, false)

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
