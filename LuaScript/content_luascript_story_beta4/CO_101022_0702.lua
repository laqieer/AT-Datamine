-- このluaスクリプトは、CO_101022_0702.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110031_01","110031_01_h")
Include("content_adv_advsmall_110031_01","Template110031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110031_01,CameraPos110031_01_004)
	InitializeTemplateRandomCamera110031_01()
	InitializeTemplate110031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110031)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それにしても、ひどいウワサだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07020002")

	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーが学園を憎んでたなんて/そんなこと、あるわけないのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:そんなことあるかねえかはともかく/仕方ねえことであるのは確かだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020004")


	--★★モルドレッド★★:このあいだの日和見野郎を見ただろ/ああいうヤツらがゴロゴロしてんのさ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020005")


	--★★モルドレッド★★:アーサーのヤロウが/俺らと敵対しやがったせいでな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020006")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:だからって/根も葉もないウワサを流すことはないだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07020007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:そもそも、生徒たちはみんな/アーサーのことが好きだったはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:ケッ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020009")


	--★★モルドレッド★★:掌返しってのはな/ケツの軽い連中の専売特許じゃねーんだぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07020012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:今回の任務だがよ/仲良しこよしで調べてちゃ効率が悪い
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020014")


	--★★モルドレッド★★:二手にわかれてやるぞ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020015")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ウワサの出所を調べればいいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07020016")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:ウワサの出所の調査と/流布をやめさせること
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★モルドレッド★★:それが依頼だ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","CO_101022_07020018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:わかった。始めよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101022_07020020")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_モルドレッド_ランクアップ7_3")
-- ▲直接出力
	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110031)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
