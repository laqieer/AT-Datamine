Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Isolde()

	load_sound("BGM_Area_Acoustic")

end

function Play()
	Play_start(false)

	bgm_play("BGM_Area_Acoustic")
	--EA_002_032002		イゾルデ・フェイルノート	"さて 偏屈商人の顔を拝みにいきましょうか"
	change_face(Isolde2, "Normal")
	open_speech_window("CHRNAME_ISOLDE2", Isolde2, nil)
	PlayPartVoice("イゾルデ", "挨拶")
	message("EA_002_032002")
	close_speech_window()
	
	--EA_002_032003		ノワール	付き合うよ
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定2")
	message("EA_002_032003")
	close_speech_window()

	--EA_002_032004		イゾルデ・フェイルノート	いいのかしら？
	change_face(Isolde2, "Surprise")
	open_speech_window("CHRNAME_ISOLDE2", Isolde2, nil)
	PlayPartVoice("イゾルデ", "驚き")
	message("EA_002_032004")
	close_speech_window()

	--EA_002_032005		ノワール	"止めようとして ついてきたわけじゃないんだ"
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoice("ノワール", "肯定")
	message("EA_002_032005")

	--EA_002_032006		ノワール	"もしかしたら俺もこのさき 誰かを見送らなければならないかもしれない"
	change_face(Noir2, "Normal")
	message("EA_002_032006")

	--EA_002_032007		ノワール	"そんなときどうすべきか知りたい…考えたいんだ だから──"
	change_face(Noir2, "Normal")
	message("EA_002_032007")
	close_speech_window()

	--EA_002_032009		イゾルデ・フェイルノート	…参考になるかはわからないけれど
	change_face(Isolde2, "Normal")
	open_speech_window("CHRNAME_ISOLDE2", Isolde2, nil)
	PlayPartVoice("イゾルデ", "悩む")
	message("EA_002_032009")

	--EA_002_032010		イゾルデ・フェイルノート	ありがとう。ノワール
	change_face(Isolde2, "Smile")
	PlayPartVoiceDirect("イゾルデ","0010")
	message("EA_002_032010")
	close_speech_window()

	bgm_play("Stop_BGM_Bus_MidFade")


	Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	setup2D_Noir_preload()
	setup2D_Isolde_preload()
	preload_sound("BGM_Area_Acoustic")
end
