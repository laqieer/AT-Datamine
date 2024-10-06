-- このluaスクリプトは、MA_01A111_901.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_015_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110021)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101053","001","101053001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あんたは銀卓騎士の…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_9010002")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("マターヤ", "笑い")
-- ▲直接出力

	--★★マターヤ★★:やあ、ノワール<br>スノードン山では世話になったね
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今日はどうしたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_9010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マターヤ", "肯定3")
-- ▲直接出力

	--★★マターヤ★★:ガラハッドとフィエナが倒れたと聞いてね<br>身柄を引き取りに来たのさ
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010005")


	--★★マターヤ★★:ふたりもここのところ無理してたし<br>コルベニック城でゆっくり休ませてやりたい
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:容体は快方に向かってるんだよな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_9010007")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("マターヤ", "悩む")
-- ▲直接出力

	--★★マターヤ★★:…正直言って<br>今はまだなんとも言えないけど
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010008")


	--★★マターヤ★★:僕たちは<br>コルベニック城でずっと一緒に暮らしてきた
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010009")


	--★★マターヤ★★:みんなの許可なしに<br>いなくなったりはしないと信じている
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:同感だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_9010011")

	PlayAction(Actor002,"to Greet_one")

	--★★マターヤ★★:それじゃ、僕はこれで
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010012")


	--★★マターヤ★★:あんまりモタモタしてると<br>オーウェンにまた小言を言われちゃうからね
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★マターヤ★★:そうそう。リリちゃんとエクセリアは<br>引き続き学園にいさせるからさ
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010014")

-- ▼直接出力
 --PlayPartVoice("マターヤ", "笑い")
-- ▲直接出力

	--★★マターヤ★★:仲良くしてやってよ
	Talk(Actor002,"CHRNAME_MATHAJIM","speech","L","MA_01A111_9010015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110021)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101053","001","101053001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
