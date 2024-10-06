Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Ragnar()

end

function Play()
	Play_start(false)


	

	bgm_play("BGM_To_Intro")
	--//ノワールが敵を撃破
	-- @ノワール	"なあ、ラグネル俺はあと何人倒せばいいんだ？"	表情：通常
	change_face(Noir2, "Normal")
	open_speech_window("PLAYERNAME_NOIR",Noir2, nil)
	PlayPartVoiceDirect("ノワール","0025")
	message("EA_001_028001")
	close_speech_window()

	-- @ラグネル	"残り何人か、なんて細かいこと気にしない！目の前にいる相手を全部倒せばいいんだよ！"	表情：通常
	change_face(Ragnar, "Laugh")
	open_speech_window("CHRNAME_RAGNAR",Ragnar, nil)
	PlayPartVoiceDirect("ラグネル","0010")
	message("EA_001_028002")
	--close_speech_window()

	-- @ラグネル	それがヒーローってもんでしょ！	表情：喜び
	change_face(Ragnar, "Smile")
	PlayPartVoiceDirect("ラグネル","0011")
	--open_speech_window("", , nil)
	message("EA_001_028003")
	close_speech_window()

	-- @ノワール	俺は別にヒーロー目指してないんだけど…	表情：困り
	change_face(Noir2, "Sad")
	open_speech_window("PLAYERNAME_NOIR",Noir2, nil)
	PlayPartVoiceDirect("ノワール","0034")
	message("EA_001_028004")
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
	setup2D_Ragnar_preload()
end
