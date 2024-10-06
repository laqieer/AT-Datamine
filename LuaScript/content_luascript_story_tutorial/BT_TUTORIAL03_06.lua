Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()
	
	setup2D_S_Noir(2)

end

-- プレイヤーフェイズ2
function Play()
	-- ランスロット攻撃
	unit_command_skill(3, 6, 10, 6, 11, 0, false)
	-- マルディサント攻撃
	unit_command_skill(7, 4, 14, 4, 13, 0, false)

	--ノワールセリフ
	change_face(Noir2, "Serious")
	open_speech_window("NPCNAME_0360",Noir2,nil) --不格好な金装（ノワール）
	message("BT_10000_1101")--くそっ…
	close_speech_window()

	--ノワールクロススラッシュ操作
	manual_command_skill(1, 5, 11, 4, 11, 1)


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
