Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()

	setup2D_S_Noir(3)

end

-- プレイヤーフェイズ1
function Play()
	Play_start(false)

	SetTrackingId(58)
	--ノワールセリフ
	change_face(Noir3, "Normal")
	open_speech_window("CHRNAME_NOIR",Noir3,nil) --ノワール
	message("BT_TUTORIAL07_010001") --身を隠しながら戦った方がいいな
	close_speech_window()



	--ギネヴィア移動
	manual_command_move(2, 6, 4)

	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(3)
end
