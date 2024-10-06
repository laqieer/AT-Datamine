Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
	demo_setup_nofade()
	
	setup2D_S_Lancelot()
	setup2D_S_Dinatan(3)
--	setup2D_S_MOB01_Soldier(7)

end

function Play()

	--ディナタン＆兵士B＆ランスロットセリフ
	change_face(Dinatan3, "Smile")
	open_speech_window("CHRNAME_DINATAN",Dinatan3,nil)--ディナタン
	message("BT_20000_0501")--ありがとう、兄さん！
	close_speech_window()


--	change_face(MOB01_Soldier7, "Normal")
--	open_speech_window("NPCNAME_0124",nil,MOB01_Soldier7)--ログレス兵（キャメロット兵）
	open_speech_window("NPCNAME_0124",nil,nil)--モブ兵士の顔表情は非表示が演出ルール
	message("BT_20000_0502")--貴様ら…よくも！
	close_speech_window()


	change_face(Lancelot, "Normal")
	open_speech_window("NPCNAME_0310",nil,Lancelot)--玲瓏な騎士(ランスロット）
	message("BT_20000_0503")--…
	close_speech_window()


	-- チュートリアルダイアログ：非ダブル時のダブルスキル
	wait_proccess(LoadTutorialPopup())
	wait_proccess(CreateTutorialPopup(1))
	wait_proccess(OpenTutorialPopup())


	-- 残りのユニット待機
	unit_command_stay(2000001, false)


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_S_Lancelot_preload()
	setup2D_S_Dinatan_preload(3)
end
