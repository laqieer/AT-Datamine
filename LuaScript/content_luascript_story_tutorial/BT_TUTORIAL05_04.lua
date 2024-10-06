Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

disableTextBox = true

function Load()
	demo_setup_nofade()

end

-- プレイヤーフェイズ2
function Play()
	Play_start(false)
	
	--ノワール移動
	manual_command_skill(1, 9, 12, 10, 12, 1)

	--ディナタン待機
	unit_command_stay(2, false)

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
end
