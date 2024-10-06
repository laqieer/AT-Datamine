-- このluaスクリプトは、PT4_01_05_002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_003)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115910)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:マスター先日の任務、お疲れ様でした
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_05_0020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ティルフィングこそ、お疲れ様
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:キャメリアードの現状は予想以上に凄惨なものでした
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_05_0020004")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:カレドニアはあの地に兵力を集め一気にログレスへ侵攻するつもりなのでしょう
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_05_0020005")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだろうな手遅れになる前に、なにか手を打たないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0020006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はいですがご注意ください
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_05_0020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:どのような策を講じるにせよ危険を避けては通れないはずですから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_05_0020008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかってるそれでも、放っておくわけにはいかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0020009")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ギネヴィアをあんな顔のままにさせておくわけにはいかないだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0020010")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:…そうですね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_05_0020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:バルバロイが相手であれば戦闘は私にお任せください
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_05_0020012")


	--★★ティルフィング★★:必ず守ってみせますマスターも…ギネヴィア様も
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","PT4_01_05_0020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありがとう頼りにしてるよ、ティルフィング
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_05_0020014")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115910)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
