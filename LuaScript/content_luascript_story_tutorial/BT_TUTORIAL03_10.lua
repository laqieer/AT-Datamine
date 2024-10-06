Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

disableTextBox = true

function Load()
	demo_setup_nofade()

	setup2D_S_Noir(2)
	setup2D_S_Sisters_1()

end

-- エナミーフェイズ3
function Play()

	-- 増援
	sortie_troops(3, 3)
	wait_seq()

	--黒帯表示
	open_textbox_base()

	--モーロノエー＆ノワールセリフ
	change_face(Sisters_1, "Smile")
	open_speech_window("CHRNAME_NAMELES",nil,Sisters_1)--???（モーロノエー）
	message("BT_10000_2001")--あっちもこっちも必死になっちゃって…
	close_speech_window()


	change_face(Noir2, "Pain")
	open_speech_window("NPCNAME_0360",Noir2,nil) --不格好な金装（ノワール）
	message("BT_10000_2002")--まだ出てくるのか！？
	close_speech_window()


	--残りのユニット待機
	unit_command_stay(2000001, false)
	unit_command_stay(2000002, false)
	unit_command_stay(2000003, false)
	unit_command_stay(2000004, false)
	unit_command_stay(2000005, false)
	unit_command_stay(2000006, false)
	unit_command_stay(2000007, false)
	unit_command_stay(2000008, false)
	unit_command_stay(2000009, false)
	unit_command_stay(2000010, false)
	unit_command_stay(2000011, false)
	unit_command_stay(2000012, false)
	unit_command_stay(2000013, false)
	unit_command_stay(2000014, false)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Noir_preload(2)
	setup2D_S_Sisters_1_preload()
end
