Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Ragnar()
	setup2D_Lola()

end

function Play()
	Play_start(false)


	bgm_play("BGM_To_Intro")
				--//ノワールが敵を撃破
	-- @ノワール	"またひとり倒したぞ！ラグネル、ローラ、トドメを頼む！"	表情：怒り・気合
	change_face(Noir2, "Anger")
	PlayPartVoiceDirect("ノワール","0012")
	open_speech_window("PLAYERNAME_NOIR",Noir2, nil)
	message("EA_001_027001")
	close_speech_window()

	-- @ラグネル	ガッテンしょーち！	表情：喜び
	change_face(Ragnar, "Smile")
	PlayPartVoiceDirect("ラグネル","0039")
	open_speech_window("CHRNAME_RAGNAR",Ragnar, nil)
	message("EA_001_027002")
	close_speech_window()

	-- @ローラ	"ふふっノワールさん、ノってきてるね"	表情：喜び
	change_face(Lola, "Smile")
	PlayPartVoiceDirect("ローラ","0010")
	open_speech_window("CHRNAME_LOLA",Lola, nil)
	message("EA_001_027003")
	close_speech_window()

	-- @ノワール	"（い、言われてみればなんか俺、楽しくなってきてる…！？）"	表情：驚き
	change_face(Noir2, "Surprise")
	open_mind_window("PLAYERNAME_NOIR",Noir2, nil)
	message("EA_001_027004")
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
