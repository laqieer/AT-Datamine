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
	-- @ローラ	ノワールさん、すごーい！	表情：喜び
	change_face(Lola , "Smile")
	PlayPartVoiceDirect("ローラ","0047")
	open_speech_window("CHRNAME_LOLA",Lola , nil)
	message("EA_001_024001")
	close_speech_window()

	-- @ノワール	"こんなことでいいならお安い御用だけど…こんなことやっちゃっていいのか？"	表情：驚き
	change_face(Noir2, "Surprise")
	PlayPartVoiceDirect("ノワール","0034")
	open_speech_window("PLAYERNAME_NOIR",Noir2 , nil)
	message("EA_001_024002")
	close_speech_window()

	-- @ラグネル	"問題なーし！ケンカを売ってきたのはオジサンたちだしね！"	表情：喜び
	change_face(Ragnar , "Smile")
	PlayPartVoiceDirect("ラグネル","0011")
	open_speech_window("CHRNAME_RAGNAR",Ragnar , nil)
	message("EA_001_024003")
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
	setup2D_Lola_preload()
end
