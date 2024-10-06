-- このluaスクリプトは、MA_01C112_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114081_01","114081_01_h")
Include("content_adv_advsmall_114081_01","Template114081_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114081_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName114081_01,CameraPos114081_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114081_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName114081_01,CameraPos114081_01_002)
	InitializeTemplateRandomCamera114081_01()
	InitializeTemplate114081_01()
-- ▼直接出力
lookat_delay_weight(Actor001, 1.0, 0, 0.5, 0.3,1.0)
Hide(Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114081)
	Actor001 = InitializeCharacter_3D("101015","003","101015003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力

	--★★モルガン★★:またひとり、飲み込まれた
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルガン★★:もうすぐ、みんなひとつになるのね<br>――私を、恨んでいるかしら
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130004")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★モルガン★★:私の悲願は魔女の総意<br>すべては、あの子の幸せのために
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130005")

-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルガン★★:そう、思っていたのに――…
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130006")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★モルガン★★:でも、私は…棄てられなかった<br>あの子がまだ、<dot>人間</dot>だったから
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130007")

-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:知らなかったわ。子供の成長って早いのね
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130009")


	--★★モルガン★★:このあいだまで、ハイハイしていたあの子が<br>いつの間にか歩くのがとても早くなって
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★モルガン★★:私の足じゃ追いつけなくて<br>もう、手も届かなくて
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130011")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)

 --PlayPartVoice("モルガン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルガン★★:…ごめんなさい、イグレーヌ<br>貴方の代わり、上手くできないみたい
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130012")


	--★★モルガン★★:…慈母に、なりたかったのになぁ
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130013")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor001,Camera001,EntryData114081_01_06,CameraAssetBundleName114081_01,CameraPos114081_01_106)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:義姉さん<br>ノワールをここに呼んだな？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C112_130015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_ik_lookat(Actor002, Actor001, "J_Head")
lookWeight = {0.9, 0, 0.5, 0.35}
lookat_delay_weight(Actor002, lookWeight,1.0)

 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:…ええ、そうよ
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルガン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:あなたが望んだことを<br>私は叶えてあげたいから
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130017")

	change_face(Actor002,"Surprise")

	--★★モルガン★★:私、間違っていたかしら？
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★アーサー★★:…いいや？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C112_130019")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:昔からずっと<br>義姉さんは俺の幸せを考えてくれているな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C112_130020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定")
-- ▲直接出力

	--★★アーサー★★:ありがとう
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C112_130021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:…ええ。大好きよ、アーサー?
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C112_130022")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114081)
	InitializeCharacter_3D_Preload("101015","003","101015003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114081_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
