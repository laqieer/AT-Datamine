-- このluaスクリプトは、MA_01108_55.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-70,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",50,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
Ef_VanishDust_TYRFING = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
local TYRFING_EfPos = get_pos(Actor002)
set_pos(Ef_VanishDust_TYRFING, TYRFING_EfPos)
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
load_image("still01", "content_still_10101021_image", "101010210_StillImage")
-- ▲直接出力
-- ▼直接出力
Ef002 =load_particle("content_effect3d_common_adv", "Ef_C_Adv_Sunbeams_Lop", false, false)
-- ▲直接出力
-- ▼直接出力
set_pos(Ef002,{1.27,4.21,-1.46})
set_rot(Ef002,{0,53.55,163.27})
-- ▲直接出力
-- ▼直接出力
on_active(Ef002)
-- ▲直接出力
-- ▼直接出力
FX_Diffusion = load_postprocess("content_adv_postprocess_diffusion", "Ef_C_PP_Diffusion", false)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002,0.8,0,08,0,5,0,10)
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060041)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","002","101001002","content_animationpack__common","FacialPack","Actor002")
	template1()
end

function Play()
	StartPlay()


	--★★ティルフィング★★:いつか
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550002")


	--★★ティルフィング★★:話の続きをしましょう
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550003")

-- ▼直接出力
 --setup_small_camera_start(RndCamera002)
setup_small_camera_start(RndCamera090)
-- ▲直接出力

	--★★ティルフィング★★:万物引き裂き錆びずの魔剣<br>願いの代価はアナタの<ruby=さだめ>運命</ruby>
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550004")


	--★★ティルフィング★★:私は継承者の<br>最初の武器としての役目を果たしました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550006")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:これからは<br><ruby=アナタ>継承者</ruby>が手にした<ruby=オリジナル>本当の武器</ruby>──
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550007")


	--★★ティルフィング★★:──この歴史における<br>『<ruby=オーセンティック>根源の武器</ruby>』を携えて
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550009")


	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_550011")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:マスター<br>私は今、とても誇らしい
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550012")


	--★★ティルフィング★★:アナタが名前を呼んでくれるのが<br>とてもうれしかった
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550013")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:幾千年の孤独を経て<br>再び誰かの力となれることがうれしかった
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550014")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…もう会えないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_550015")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…アナタのかたわらからは離れます<br>ですが、最初の武器の心はいつでもアナタと共に
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550016")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
on_active(Ef_VanishDust_TYRFING) 
-- ▲直接出力
-- ▼直接出力
play_particle(Ef_VanishDust_TYRFING)
-- ▲直接出力
-- ▼直接出力
wait_time(3.2)
-- ▲直接出力

	--★★ティルフィング★★:私の声が、まだ聞こえますか？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_550019")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
on_active(FX_Diffusion)
wait_time(1.2)
-- ▲直接出力

	--★★ティルフィング★★:歴史が語る<br>『<ruby=ラ・コート・マルタイユ>不格好なコート</ruby>』──
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550020")


	--★★ティルフィング★★:黄金の輝きを絶やさぬ騎士
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01108_550022")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
 se_play("SE_ADV_MA_01B900_13_Wind_Blow")
-- ▲直接出力
-- ▼直接出力
wait_time(1.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Joy")
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
wait_time(3.2)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
 --ティルフィング消滅
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(true)
show_image("still01", 0.0, 0.0, 0.0, true, false)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME+1.2)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:…叶いますよ、その願い
	Talk(Actor002,"CHRNAME_TYRFING","simple","L","MA_01108_550023")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:ティルフィング…
	Talk(Actor001,"CHRNAME_NOIR","simple","L","MA_01108_550024")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★ティルフィング★★:さあマスター
	Talk(Actor002,"CHRNAME_TYRFING","simple","L","MA_01108_550025")

-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
fadeout(255,255,255,1.0, FADE_TIME)
se_play("SE_ADV_MA_01108_55_disappear")
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_VanishDust_TYRFING)
-- ▲直接出力
-- ▼直接出力
stop_particle(Ef_VanishDust_TYRFING)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…話を、続けてください
	Talk(Actor002,"CHRNAME_TYRFING","simple","N","MA_01108_550027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VanishDust", false, true)
load_image_preload("still01", "content_still_10101021_image", "101010210_StillImage")
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Sunbeams_Lop", false, false)
load_postprocess_preload("content_adv_postprocess_diffusion", "Ef_C_PP_Diffusion", false)
	InitializeLoad_Preload()
	load_duel_scene_preload(101060041)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","002","101001002","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
