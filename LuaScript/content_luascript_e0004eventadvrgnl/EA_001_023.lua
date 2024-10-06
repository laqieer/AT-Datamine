Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Ragnar()
	setup2D_Lola()

end

function Play()
	Play_start(false)


	bgm_play("BGM_To_Intro")
	-- @ノワール	"よし、まずひとり！…これでいいのか、ラグネル？"	表情：怒り・気合
	change_face(Noir2, "Anger")
	open_speech_window("CHRNAME_NOIR",Noir2 , nil)
	voice_play("VO_101009_sp_0012_1")
	message("EA_001_023001")
	close_speech_window()

	-- @ラグネル	"うん、バッチリ！さぁ、やるよ、ローラちゃん！"	表情：喜び
	change_face(Ragnar, "Smile")
	open_speech_window("CHRNAME_RAGNAR",Ragnar , nil)
	PlayPartVoiceDirect("ラグネル","0007")
	message("EA_001_023002")
	close_speech_window()

	-- @ローラ	"準備できてます！いつでもどうぞ！"	表情：怒り・気合
	change_face(Lola, "Anger")
	open_speech_window("CHRNAME_LOLA",Lola , nil)
	message("EA_001_023003")
	close_speech_window()

	-- @ログレス兵	"な、なにをする気だ？や、やめろ！やめてくれ！うわあああああっ…"	
	open_speech_window("NPCNAME_0124",nil , nil)
	message("EA_001_023004")
	close_speech_window()

	-- @ノワール	"（なにが起きている…？気になるけど、俺は頼まれたことに専念しよう…）"	表情：驚き
	change_face(Noir2, "Surprise")
	PlayPartVoiceDirect("ノワール","0043")
	open_mind_window("CHRNAME_NOIR",Noir2 , nil)
	message("EA_001_023005")
	close_mind_window()

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
	setup2D_Lola_preload()
end
