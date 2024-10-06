Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Ragnar()
	setup2D_Lola()
	setup2D_Isolde()

end

function Play()
	Play_start(false)


	bgm_play("BGM_To_Intro")
				--//ノワールが敵を撃破
	-- @ラグネル	"くらえ必殺、まつり縫い～！…お祭りが近いだけにね"	表情：通常
	--ト書きで表情が通常になっていますがあっていなかったため笑いに
	change_face(Ragnar, "Smile")
	PlayPartVoiceDirect("ラグネル","0035")
	open_speech_window("CHRNAME_RAGNAR", Ragnar, nil)
	message("EA_001_026001")
	close_speech_window()

	-- @ローラ	あははっ！	表情：喜び
	change_face(Lola, "Smile")
	PlayPartVoiceDirect("ローラ","0011")
	open_speech_window("CHRNAME_LOLA",Lola, nil)
	message("EA_001_026002")
	--close_speech_window()

	-- @ローラ	"ラグネルさんの裁縫技術はいつ見ても感心します早くて丁寧で、仕上がりも綺麗！"	表情：通常
	--ト書きで表情が通常になっていますがあっていなかったため笑いに
	change_face(Lola, "Smile")
	PlayPartVoiceDirect("ローラ","0047")
	--open_speech_window("", , nil)
	message("EA_001_026003")
	close_speech_window()

	-- @イゾルデ	"（確かに趣味のレベルをはるかに超えているわね）"	表情：通常
	change_face(Isolde, "Normal")
	PlayPartVoiceDirect("イゾルデ","0045")
	open_mind_window("CHRNAME_ISOLDE",Isolde, nil)
	message("EA_001_026004")
	--close_speech_window()

	-- @イゾルデ	"（…ちょっと待ちなさい、私今驚くべきはそこで合っているのかしら？）"	表情：驚き
	change_face(Isolde, "Surprise")
	--open_speech_window("", , nil)
	message("EA_001_026005")
	close_mind_window()

	bgm_play("BGM_To_Main")


	
	Play_end(false)
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Ragnar_preload()
	setup2D_Lola_preload()
	setup2D_Isolde_preload()
end
