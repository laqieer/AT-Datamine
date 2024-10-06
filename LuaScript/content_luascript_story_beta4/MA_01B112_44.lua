-- このluaスクリプトは、MA_01B112_44.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115119)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ディナタン、調子はどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_440002")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:あっ！兄さん<br>包装はもう終わったの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_440003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。いくつか持ってきたし<br>プレゼントを配るの、手伝おうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_440004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:手持ちのぶん、もうすぐ終わるから<br>兄さんが持ってきた追加は私が預かるよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_440005")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:聖杯城での戦いでいろいろあったんでしょ？<br>兄さんは休めるときに休んで
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_440006")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:私たち…兄さんに頼りっきりだもん<br>いつも背負わせすぎちゃって、ごめんね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_440007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:もうすぐ『本当』のことがわかる<br>ディナタンが…みんなが支えてくれたおかげだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_440008")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:その恩を返すことは<br>重荷でもなんでもないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_440009")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:兄さん…ありがとう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_440010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("子供_男1", "挨拶")
-- ▲直接出力

	--★★子供（男）★★:ねーねーおねえちゃん<br>ぼくのプレゼントは―？
	Talk(Actor003,"NPCNAME_0077","speech","N","MA_01B112_440011")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:あっ、ごめんね！今渡すからね<br>…兄さん、またあとで！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B112_440012")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115119)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
