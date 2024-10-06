Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Noir(2)

end

-- プレイヤーフェイズ1
function Play()

	--ノワールセリフ
	change_face(Noir2, "Normal")
	open_speech_window("NPCNAME_0360",Noir2,nil) --不格好な金装（ノワール）
	message("BT_10000_0101")--数ではこちらが負けてる
	close_speech_window()


	--ノワール通常攻撃操作
	manual_command_skill(1, 5, 12, 6, 12, 0)
	wait_seq()


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(2)
end
