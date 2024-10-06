Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Isolde()

end

function Play()
	Play_start(false)
					

	bgm_play("BGM_To_Intro")
				--//ノワールが敵を撃破
	-- @ノワール	"イゾルデなんていうか、その…ごめん"	表情：困り
	change_face(Noir2, "Sad")
	PlayPartVoiceDirect("ノワール","0025")
	open_speech_window("PLAYERNAME_NOIR",Noir2, nil)
	message("EA_001_025001")
	close_speech_window()

	-- @イゾルデ	"？なぜお前が私に謝るのかしら"	表情：通常
	change_face(Isolde, "Normal")
	open_speech_window("CHRNAME_ISOLDE",Isolde , nil)
	message("EA_001_025002")
	close_speech_window()

	-- @ノワール	"兵士たちを連れて来てくれたじゃないかいろいろ根回しした末にだろうに、こんな…"	表情：困り
	change_face(Noir2, "Sad")
	open_speech_window("PLAYERNAME_NOIR",Noir2, nil)
	message("EA_001_025003")
	close_speech_window()

	-- @イゾルデ	"彼らがムシャクシャしていると言っていたから私はストレス発散の方法を教えただけよ"	表情：通常
	change_face(Isolde, "Normal")
	PlayPartVoiceDirect("イゾルデ","0013")
	open_speech_window("CHRNAME_ISOLDE",Isolde, nil)
	message("EA_001_025004")
	--close_speech_window()

	-- @イゾルデ	"その結果痛い目に遭おうが私の知ったことではないわ"	表情：通常
	--open_speech_window("", , nil)
	message("EA_001_025005")
	close_speech_window()

	-- @ログレス兵	ひ、ひどい！	
	open_speech_window("NPCNAME_0124",nil , nil)
	message("EA_001_025006")
	close_speech_window()

	bgm_play("BGM_To_Main")


	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Isolde_preload()
end
