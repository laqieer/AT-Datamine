-- このluaスクリプトは、EA_066_052.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_116101_01","116101_01_h")
Include("content_adv_advsmall_116101_01","Template116101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos116101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName116101_01,CameraPos116101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos116101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName116101_01,CameraPos116101_01_001)
	Camera003 = SetTemplate("Actor003",30,CharaPos116101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName116101_01,CameraPos116101_01_003)
	InitializeTemplateRandomCamera116101_01()
	InitializeTemplate116101_01()
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
seihai = setup_prop_object(10201022)
set_pos(seihai,{-0.115, 1.358, 0.8})
Ef_Holy_Grail01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", true, true)
Ef_Holy_Grail02 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail02", true, true)
set_pos(Ef_Holy_Grail01, {-0.115, 1.358, 0.8})
set_pos(Ef_Holy_Grail02, {-0.115, 1.358, 0.8})
-- ▲直接出力
-- ▼直接出力
off_active(seihai)
off_active(Ef_Holy_Grail01)
off_active(Ef_Holy_Grail02)
stop_particle(Ef_Holy_Grail01)
stop_particle(Ef_Holy_Grail02)
-- ▲直接出力
-- ▼直接出力
load_image("201010910","content_still_20101091_image","201010910_StillImage")
load_image("101010140","content_still_10101014_image","101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
fadein(0,0,0,1.0, FADE_TIME)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116101)
	Actor001 = InitializeCharacter_3D("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoiceDirect("ヴォールス","0007")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:そうだ。俺がもっと強ければ
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0520003")


	--★★ヴォールス★★:バルバロイすべてを倒し切れる力が俺にあれば<br>あの選択をさせずに済んだんじゃないか
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0520004")


	--★★ヴォールス★★:世界のためだと辛い選択を強いて<br>ノワールをひとりにした――…
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0520005")

-- ▼直接出力
force_eyesync(Actor001,"Close")
-- ▲直接出力

	--★★ヴォールス★★:俺があいつらのように、強くなかったから――
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0520006")


	--★★テロップ★★:――本当に？
	Talk(Actor004,"","simple","N","EA_066_0520009")

-- ▼直接出力
force_eyesync(Actor001,"Auto")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:…え
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0520010")


	--★★テロップ★★:本当に、彼は初めから強かっただろうか<br>『彼女』は強かっただろうか
	Talk(Actor004,"","simple","N","EA_066_0520011")

-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ヴォールス_002","0015")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ヴォールス★★:彼女…？誰のことだ――<br>思い出せない――
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0520012")


	--★★テロップ★★:『彼女』が強くなったのは――<br>強くあろうとしたのは――
	Talk(Actor004,"","simple","N","EA_066_0520013")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_start(Camera002)
Hide(Actor001)
hide_image(0)
on_active(seihai)
on_active(Ef_Holy_Grail01)
on_active(Ef_Holy_Grail02)
play_particle(Ef_Holy_Grail01)
play_particle(Ef_Holy_Grail02)
wait_time(0.5)
fadein(1.0)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(4)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_start(Camera003)
off_active(seihai)
off_active(Ef_Holy_Grail01)
off_active(Ef_Holy_Grail02)
stop_particle(Ef_Holy_Grail01)
stop_particle(Ef_Holy_Grail02)
wait_time(0.5)
fadein(1.0)
wait_time(0.5)
-- ▲直接出力

	--★★？？？★★:「わたしたちの思い出すら食い物にされちゃたまんないのよ」
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","EA_066_0520018")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0,1.0)
wait_time(FADE_TIME)
setup_small_camera_start(Camera003)
Appear(Actor003)
wait_time(0.5)
fadein(1.0)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ヴォールス★★:…！
	Talk(Actor001,"CHRNAME_BORS","speech","L","EA_066_0520019")

-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Angry")
SkipDefaultMotion(Actor003)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★？？？★★:死んだように生きてくだけじゃ意味ないのよ…！
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","EA_066_0520020")


	--★★？？？★★:飾って、なんかダメで、また飾って、間違えて飾り立てて、褒められて、嬉しくって
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","EA_066_0520021")

	PlayAction(Actor003,"to Std_Loop")

	--★★？？？★★:そうしてるうちに<br>飾らない自分も好きになれる…愛おしくなる
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","EA_066_0520022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★？？？★★:それがわたしよ！！<br>死んでもあなたにくれてなんかやんない！！
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","EA_066_0520023")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME+1.0)
wait_time(FADE_TIME+1.0)
show_image("201010910", 0.0, 0.0, STILL_SWITCH_TIME ,true,true)
set_scale_image(0.8,0.8)
wait_time(0.5)
fadein(1.0)
bgm_play("Stop_BGM_Bus_2")
wait_time(1.4)
-- ▲直接出力

	--★★ノワール★★:俺たちは<br>選んでここにいる
	Talk(Actor002,"CHRNAME_NOIR","simple","N","EA_066_0520025")

	change_face(Actor001,"Normal")

	--★★ヴォールス★★:………！
	Talk(Actor001,"CHRNAME_BORS","simple","N","EA_066_0520026")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10201022)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail01", true, true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Holy_Grail02", true, true)
load_image_preload("201010910","content_still_20101091_image","201010910_StillImage")
load_image_preload("101010140","content_still_10101014_image","101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116101)
	InitializeCharacter_3D_Preload("101024","002","101024002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName116101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
