Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")


function Load()
	Load_common(false)

	setup2D_Noir()
	setup2D_Isolde()
	setup2D_Bors()
	
end

function Play()
	Play_start(false)

	--EA_002_042002		イゾルデ	………あーあ
	change_face(Isolde2, "Sad")
	open_speech_window("CHRNAME_ISOLDE2", Isolde2, nil)
	PlayPartVoice("イゾルデ", "落胆")
	message("EA_002_042002")
	close_speech_window()

	--EA_002_042003		ヴォールス	賭場を荒らしてはいけないな
	change_face(Bors, "Normal")
	open_speech_window("CHRNAME_BORS", Bors, nil)
	PlayPartVoice("ヴォールス", "落胆")
	message("EA_002_042003")
	close_speech_window()

	--EA_002_042004		商人	"こ、こんなこともあろうかと 買い付けておいた獣どもだあっ！！"
	open_speech_window("NPCNAME_0303", nil, nil)
	PlayPartVoice("市民_男1","落胆")
	message("EA_002_042004")
	close_speech_window()

	--EA_002_042005		ノワール	"負けを見越しているなんて 大したギャンブラーだ"
	change_face(Noir2, "Normal")
	open_speech_window("CHRNAME_NOIR", Noir2, nil)
	PlayPartVoiceDirect("ノワール","0001")
	message("EA_002_042005")
	close_speech_window()

	--EA_002_042006		商人	"負けてはいない！ 出目を見るまでは負けていなあい！！"
	open_speech_window("NPCNAME_0303", nil, nil)
	PlayPartVoiceDirect("市民_男1","0016")
	message("EA_002_042006")
	close_speech_window()

	--EA_002_042007		イゾルデ	"ガッカリ こんな勝敗──"
	change_face(Isolde2, "Normal")
	open_speech_window("CHRNAME_ISOLDE2", Isolde2, nil)
	PlayPartVoiceDirect("イゾルデ","0033")
	message("EA_002_042007")

	--EA_002_042008		イゾルデ	賭けるまでもないわ
	change_face(Isolde2, "Anger")
	PlayPartVoice("イゾルデ", "激怒")
	message("EA_002_042008")
	close_speech_window()



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
	setup2D_Bors_preload()
end
