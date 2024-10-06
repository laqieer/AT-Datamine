-- このluaスクリプトは、PT4_01_08_003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力

	--★★モルドレッド★★:よぉ、継承者朝から暇そうにしてんじゃねぇか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "挨拶")
-- ▲直接出力

	--★★クラリス★★:おはようございます～ノワールくん
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","PT4_01_08_0030003")

-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:モルドレッドにクラリス？珍しいな、寮に来るなんて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:リアムさんのお使いで来たんですそうしたらモルくんもついてきてくれて～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","PT4_01_08_0030005")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:こいつは目ェ離すとすぐに迷子になりやがるからな
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030006")

	change_face(Actor001,"Normal")

	--★★ノワール★★:（朝から暇だったってことか）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT4_01_08_0030007")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★モルドレッド★★:それはそうと、てめえこそあの銀卓騎士から目ェ離すんじゃねえぞ？
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ガラハッドのことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0030009")

-- ▼直接出力
PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力

	--★★モルドレッド★★:他に誰がいんだよオレはどうにもアイツが信用ならねえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030010")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:そうか？まっすぐで、純粋で、いい子だと思うけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0030011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "笑い")
-- ▲直接出力

	--★★クラリス★★:ノワールくんも負けないくらいまっすぐで、純粋で、いい子だと思いますよ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","PT4_01_08_0030012")


	--★★モルドレッド★★:………
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030013")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("モルドレッド", "苦しみ")
-- ▲直接出力

	--★★モルドレッド★★:円卓が信用ならねぇってんでてめえんとこで騎士団を結成しときながら
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030014")

	PlayAction(Actor002,"to  Std_Talk")

	--★★モルドレッド★★:いざとなったら円卓を頼んのか？ムシが良すぎンだろ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:銀卓騎士団の結成理由がそういうウワサってだけだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0030016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:それに、ガラハッドはカレドニアと戦ってた少なくとも敵ではないと俺は思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT4_01_08_0030017")

-- ▼直接出力
PlayPartVoice("クラリス", "喜び")
-- ▲直接出力

	--★★クラリス★★:敵の敵は味方ってことですね～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","PT4_01_08_0030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("モルドレッド", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:だぁーっ！おめえが出てくると話が見えなくなんだよ！！
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030019")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クラリス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:あうぅ…ごめんなさい…
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","PT4_01_08_0030020")

-- ▼直接出力
PlayPartVoice("モルドレッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:チッ。クラリス、用事は終わったんだろ？だったらさっさと帰んぞ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","PT4_01_08_0030021")

-- ▼直接出力
PlayPartVoice("クラリス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★クラリス★★:はいぃ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","PT4_01_08_0030022")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:（話、終わってない気がするけど…クラリスが切り上げさせてくれたのかな？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","PT4_01_08_0030023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
