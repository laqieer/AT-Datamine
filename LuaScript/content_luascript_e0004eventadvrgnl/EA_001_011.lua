-- このluaスクリプトは、EA_001_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_02","110901_02_h")
Include("content_adv_advsmall_110901_02","Template110901_02_h")
-- ▼直接出力
Include("content_adv_advsmall_110901_01","110901_01_h")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110901_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110901_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110901_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110901_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_007)
	Camera008 = SetTemplate("Actor008",-40,CharaPos110901_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_006)
	InitializeTemplateRandomCamera110901_02()
	InitializeTemplate110901_02()
-- ▼直接出力
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
load_image("insert_001", "content_still_10305008_image", "103050080_StillImage")
show_image("insert_001", 0.0, 0.0, 0 ,true,true) 
set_position_image(-120, 0)
move_to_image(0,0,15,0)
-- ▲直接出力
-- ▼直接出力
load_image("insert_002", "content_still_10305009_image", "103050090_StillImage")
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006, CharaPos110901_01_002)
set_rot(Actor006,{0,CharaPos110901_01_002[4],0})
CameraEX_1 = set_camera({0.518,0.995,-0.477,5.36405,276.4954,0.01305,22})
keep_ik_lookat(Actor006, Actor007, "J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007, CharaPos110901_01_004)
set_rot(Actor007,{0,CharaPos110901_01_004[4],0})
CameraEX_2 = set_camera({1.175,0.89,0.688,-0.7,-21.735,-0.52,22})
keep_ik_lookat(Actor007, Actor006, "J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
CameraEX_3 = set_camera({-4.208,1.696,1.285,6.729,-14.943,0.938,25})
-- ▲直接出力
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
set_postprocess_enum_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "UnityEngine.Rendering.Universal.DepthOfFieldModeParameter", "mode", "UnityEngine.Rendering.Universal.DepthOfFieldMode", "Gaussian")
gaussian_start_CameraEX_1 = 1.5
gaussian_end_CameraEX_1 = 3
gaussian_max_radius_CameraEX_1 = 1.5
gaussian_start_CameraEX_2 = 3.2
gaussian_end_CameraEX_2 = 4
gaussian_max_radius_CameraEX_2 = 1.5
-- ▲直接出力
-- ▼直接出力
kakusu_obj = get_object("geo_obj_b")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
end

function Play()
	StartPlay()

	change_face(Actor006,"Laugh")

	--★★ラグネル★★:いっつもドンマイって感じだよ
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011002")

	change_face(Actor006,"Normal")

	--★★ラグネル★★:お気に入りのかわいいアウターなのに<br>サイズ感が合わなくて落ち着かない、とか
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011003")

-- ▼直接出力
setup_small_camera_start(CameraEX_1)
slidemove(CameraEX_1,{0.5129,0.995,-0.52},6.0)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start_CameraEX_1)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end_CameraEX_1)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius_CameraEX_1)
-- ▲直接出力
-- ▼直接出力
on_active(FX_DoF)
-- ▲直接出力

	--★★ラグネル★★:新品なのに着れずじまい<br>だからもう眺めてるだけでもいいかな～とか
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011004")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:その経験が<br>いまのラグネルさんを構築していると？
	Talk(Actor007,"telop","simple","N","EA_001_011006")


	--★★ラグネル★★:うん。みんなさ<br>好きでも合わないことってあるよね
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011007")

	change_face(Actor006,"Laugh")

	--★★ラグネル★★:でもせめて自分が好きなものを…こう、並べてさ<br>みんなに知ってもらえるだけでも嬉しいじゃん
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011008")


	--★★ラグネル★★:夜が不安だった幼いころ…かわいいぬいぐるみが<br>みんなを笑顔にしてくれたように
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011009")

	change_face(Actor006,"Smile")

	--★★ラグネル★★:あたしもそれができないかなって思ってるんだ<br>どうやったらいいかは考え中だけど（笑）
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011010")


	--★★キャメロット騎士学術院（男）★★:美学ですね（笑）<br>いまそうしてあげたい相手はいますか？
	Talk(Actor007,"telop","simple","N","EA_001_011011")

-- ▼直接出力
show_image("insert_002", 0.0, 0.0, 0 ,true,true) 
set_position_image(0,36)
move_to_image(0,0,15,2)
off_active(FX_DoF)
-- ▲直接出力
-- ▼直接出力
 --wait_time(1.5)
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★ラグネル★★:話題の転校生、いるよね<br>彼のこと…ちょっと気になってるんだ
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011012")

-- ▼直接出力
setup_small_camera_start(CameraEX_3)
turn(CameraEX_3,{8.518,-14.913,0.942},7.0)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start_CameraEX_2)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end_CameraEX_2)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius_CameraEX_2)
Appear(Actor008)
on_active(FX_DoF)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:先月…入学早々、円卓の騎士となった<br><ruby=ラ・コート・マルタイユ>『不格好なコート』</ruby>ですね？
	Talk(Actor007,"telop","simple","N","EA_001_011014")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME+STILL_PASSIVE_AFTER)
-- ▲直接出力

	--★★ラグネル★★:彼…いつだか<br>「置き去りにされたくない」って言ってた
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011016")

	change_face(Actor006,"Sad")

	--★★ラグネル★★:なにに焦ってるんだろ。わかんなくて
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011017")


	--★★ラグネル★★:でも、なにかを追っかけるために<br>ムリしていきなり大役背負って──
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011018")


	--★★キャメロット騎士学術院（男）★★:似合ってませんものね<br>戦場で来ている金色のコートも含めて
	Talk(Actor007,"telop","simple","N","EA_001_011019")

	change_face(Actor006,"Normal")

	--★★ラグネル★★:着心地…悪くないのかなあ
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011020")

-- ▼直接出力
setup_small_camera_start(CameraEX_2)
slidemove(CameraEX_2,{1.208,0.89,0.701},6.0)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianStart", gaussian_start_CameraEX_1)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianEnd", gaussian_end_CameraEX_1)
set_postprocess_float_paramter(FX_DoF, "UnityEngine.Rendering.Universal.DepthOfField", "gaussianMaxRadius", gaussian_max_radius_CameraEX_1)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:それでは最後となりますが<br>五月祭に向けて意気込みを伺いたいです
	Talk(Actor007,"telop","simple","N","EA_001_011021")

-- ▼直接出力
Appear(Actor001)
Appear(Actor003)
Appear(Actor004)
Appear(Actor005)
Hide(Actor008)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:城下町に出店する屋台…<br>隣は素人料理<ruby=サークル>同好会</ruby>だそうですね
	Talk(Actor007,"telop","simple","N","EA_001_011022")


	--★★キャメロット騎士学術院（男）★★:エースのガレス氏擁する調理部に勝とうと<br>炎を上げる派手な料理を用意しているようですが
	Talk(Actor007,"telop","simple","N","EA_001_011024")

	change_face(Actor006,"Smile")

	--★★ラグネル★★:それすごいね！見てみたいなっ<br><ruby=サークル>同好会</ruby>同士、お祭りは知名度を上げるチャンス！
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011025")


	--★★ラグネル★★:みんなでたのしもー！
	Talk(Actor006,"CHRNAME_RAGNAR","simple","N","EA_001_011026")

-- ▼直接出力
CloseTalkWindow()
off_active(FX_DoF)
setup_small_camera_start(RndCamera002)
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力

	--★★テロップ★★:『新聞部<br>臨時特集企画』
	Talk(Actor009,"telop","simple","N","EA_001_011027")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★テロップ★★:『五月祭で摘み取られる日陰者たち<br>廃部寸前？かわいそうな手芸サークルに迫る！』
	Talk(Actor009,"telop","simple","N","EA_001_011028")

	EndPlay()
end

