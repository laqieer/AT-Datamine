-- このluaスクリプトは、MA_01C900_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_02","114101_02_h")
Include("content_adv_advsmall_114101_02","Template114101_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_03_MA01C900_29_Controller","to Sit01_Loop",CameraAssetBundleName114101_02,CameraPos114101_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114101_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_02_MA01C900_29_Controller","to Sit01_Loop",CameraAssetBundleName114101_02,CameraPos114101_02_002)
	InitializeTemplateRandomCamera114101_02()
	InitializeTemplate114101_02()
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField_MA_01C900_29_1", false)
FX_DoF2 = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField_MA_01C900_29_2", false)
FX_DoF3 = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField_MA_01C900_29_3", false)
-- ▲直接出力
-- ▼直接出力
CUT_01 = cat_template_camera("P10_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_02 = cat_template_camera("P11_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_03 = cat_template_camera("P12_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_04 = cat_template_camera("P13_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_05 = cat_template_camera("P14_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_06 = cat_template_camera("P15_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_07 = cat_template_camera("P16_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_08 = cat_template_camera("P17_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_09 = cat_template_camera("P18_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_10 = cat_template_camera("P19_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_11 = cat_template_camera("P20_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_12 = cat_template_camera("P21_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_13 = cat_template_camera("P22_Cam")
-- ▲直接出力
-- ▼直接出力
CUT_14 = cat_template_camera("P23_Cam")
-- ▲直接出力
-- ▼直接出力
RndCamera001 = CUT_13
-- ▲直接出力
-- ▼直接出力
sword001 = set_object("content_model_weapon_01_swd_wpn_01_swd_015", "Wpn_01_swd_015", true)
-- ▲直接出力
-- ▼直接出力
set_pos(sword001,CharaPos114101_02_004)
-- ▲直接出力
-- ▼直接出力
set_rot(sword001,{40,42,47})
-- ▲直接出力
-- ▼直接出力
off_active(sword001)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140_1", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Ef_F05 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Holy_Grail_ForcefulLight",false,true)
set_pos(Ef_F05,{0.05,0.08,-11.14})
Ef_F13 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_BalNoiz01_L_Lop",false,true)
set_pos(Ef_F13,{-0.130461276,0.314501911,-0.467355937})
Ef_F15 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Flash_White04",false,true)
set_pos(Ef_F15,{0,0,-32})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
FX_Refractive = load_postprocess("content_adv_postprocess_refractive", "Ef_C_PP_Refractive", false)
FX_Glitch = load_postprocess("content_adv_postprocess_glitch", "Ef_C_PP_Glitch", false)
FX_Distortion = load_particle("content_effect3d_common_adv", "Ef_C_Adv_Distortion", false, true)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Sing_Forest")
-- ▲直接出力
-- ▼直接出力
Ef_C_Adv_Dust01 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Dust01",false,true)
set_pos(Ef_C_Adv_Dust01,{-1,-1,-15})
set_rot(Ef_C_Adv_Dust01,{0,0,-22})
-- ▲直接出力
-- ▼直接出力
Ef_C_Adv_Flare01 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Flare01",false,true)
set_pos(Ef_C_Adv_Flare01,{-0.4,-0.3,-15})
set_rot(Ef_C_Adv_Flare01,{0,0,-22})
set_scale(Ef_C_Adv_Flare01,{5,5,5})
-- ▲直接出力
-- ▼直接出力
Ef_C_Adv_BalNoiz04_L_Lop =  load_particle("content_effect3d_common_adv","Ef_C_Adv_BalNoiz04_L_Lop",false,true)
set_pos(Ef_C_Adv_BalNoiz04_L_Lop,{-0.4,-0.3,-15})
set_rot(Ef_C_Adv_BalNoiz04_L_Lop,{0,0,-22})
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10104026_anim", "10104026_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","002","101012002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor005 = InitializeCharacter_2DOnly("101012","002","101012002")
	template1()
end

function Play()
	StartPlay()

-- ▼直接出力
	close_textbox_base()
	disableTextBox = true
	bgm_play("BGM_ADV_Sing_Forest")
	stillAnime.SetActive(true)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
	wait_time(2.0)
	signal = play_ui_timeline_controller_out(stillAnime, true)
	wait_time(0.5)
	while signal.IsProccessing() do
		coroutine.yield()
	end
fadeout(0,0,0,1,0.2)
wait_time(0.5)
stillAnime.SetActive(false)
setup_small_camera_start(CUT_01)
fadein(0.5)
-- ▲直接出力
-- ▼直接出力
wait_time(5.0)
PlayActionDirect(Actor002,"to Sit01_Loop_2")
setup_small_camera_start(CUT_02)
on_active(FX_DoF)
wait_time(4.0)
PlayActionDirect(Actor002,"to Sit02_Loop")
disableTextBox = false
open_textbox_base()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール_1★★:やっぱりディナタンの歌はいいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor001,"to Sit02_loop")
setup_small_camera_start(CUT_03)
off_active(FX_DoF)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン_1★★:…ふふ<br>ありがとう兄さん
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290003")

	change_face(Actor002,"Normal")

	--★★ディナタン_1★★:ふたりきりの時間なんて<br>ずいぶんひさしぶりな気がするね
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290004")

	change_face(Actor001,"Normal")

	--★★ノワール_1★★:いつも誰かが一緒にいたからな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290005")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
PlayActionDirect(Actor002,"to Sit03_Loop")
setup_small_camera_start(CUT_04)
on_active(FX_DoF)
wait_time(2.0)
-- ▲直接出力

	--★★ディナタン_1★★:早くこの森から出たい？
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290006")

	change_face(Actor002,"Sad")

	--★★ディナタン_1★★:ふたりきりだとつまらないでしょ
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290007")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_05)
off_active(FX_DoF)
on_active(FX_DoF2)
wait_time(2.2)
PlayActionDirect(Actor001,"to Sit03_loop")
wait_time(0.5)
-- ▲直接出力

	--★★ノワール_1★★:…そうだな、早くみんなのところに<br>帰りたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290008")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_06)
off_active(FX_DoF2)
wait_time(0.3)
-- ▲直接出力

	--★★ディナタン_1★★:うん。そうだよね<br>そう思うのが普通だよ
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290009")

	change_face(Actor002,"Normal")

	--★★ディナタン_1★★:でも…本当はね、このままでもいいかなって<br>ちょっとだけ思う
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290010")


	--★★ディナタン_1★★:誰もいないこの森で<br>ずっと兄さんとふたりで
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290011")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Sit02_loop_2")
wait_time(0.5)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール_1★★:ディナタン…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290012")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_07)
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT_08)
-- ▲直接出力

	--★★ディナタン_1★★:ずっと昔、こんなことをしていた記憶が<br>ある気がする
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290013")

	change_face(Actor001,"Sad")

	--★★ノワール_1★★:…俺たちにはどこかで勝手に失われた記憶が<br>あるのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290014")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
fadeout(255,255,255,1.0, 1.0)
wait_time(1.0)
set_bgparameters(true, 1, "#FFFFFF")
Hide(Actor002)
Hide(Actor001)
on_active(sword001)
on_active(Ef_F05)
play_particle(Ef_F05)
wait_time(0.5)
setup_small_camera_start(CUT_09)
fadein(1.0)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Smile")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ディナタン2D★★:でも記憶は少しだけ残って<br>それは私たちを守ってくれているのかも
	Talk(Actor005,"CHRNAME_DINATAN2","speech","L","MA_01C900_290015")


	--★★ノワール2D★★:…そうかもしれないな<br>大切に遺された武器みたいに
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C900_290016")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
fadeout(255,255,255,1.0, 1.0)
wait_time(1.0)
set_bgparameters(false, 0, "#000000")
Appear(Actor002)
Appear(Actor001)
off_active(sword001)
off_active(Ef_F05)
setup_small_camera_start(CUT_10)
on_active(FX_DoF3)
fadein(1.0)
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン_1★★:………
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290017")

	change_face(Actor001,"Normal")

	--★★ノワール_1★★:ディナタン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290018")

	change_face(Actor002,"Smile")

	--★★ディナタン_1★★:私ね、兄さんと兄妹じゃなかったらって<br>考えたことがあるの。兄さんはない？
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290019")

-- ▼直接出力
PlayActionDirect(Actor002,"to Sit02_Loop_2")
-- ▲直接出力

	--★★ディナタン_1★★:そうだよね…
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290044")


	--★★ノワール_1★★:考えたこともなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290020")

	change_face(Actor002,"Sad")

	--★★ディナタン_1★★:そっか…
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290021")

	change_face(Actor002,"Normal")

	--★★ディナタン_1★★:そうだよね…
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290022")


	--★★ディナタン_1★★:私は、私はね…<br>うん、なんでもない
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290023")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_11)
wait_time(2.0)
PlayActionDirect(Actor002,"to Sit03_Loop")
-- ▲直接出力

	--★★ディナタン_1★★:私、兄さんと兄妹でよかった<br>兄さんの武器になれて、よかった
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290045")


	--★★ノワール_1★★:どうしたんだよ、ディナタン<br>なんだか変だぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290025")


	--★★ディナタン_1★★:なんでもないよ
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290026")

	change_face(Actor002,"Smile")

	--★★ディナタン_1★★:私、兄さんと兄妹でよかった<br>兄さんの武器になれて、よかった
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290027")


	--★★ノワール_1★★:ディナタン――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_290028")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(CUT_12)
off_active(FX_DoF3)
on_active(FX_DoF2)
wait_time(0.3)
-- ▲直接出力

	--★★ディナタン_1★★:あーあ<br>なんだか少し眠くなって来ちゃった
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290030")


	--★★ディナタン_1★★:兄さんも一緒に寝ようよ<br>子守歌、歌ってあげるから
	Talk(Actor002,"CHRNAME_DINATAN2","speech","L","MA_01C900_290031")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
PlayActionDirect(Actor001,"to Sleep01")
wait_time(2.5)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME)
setup_small_camera_start(CUT_14)
off_active(FX_DoF2)
set_bgparameters(true, 1, "#000000")
wait_time(0.5)
Hide(Actor002)
Hide(Actor001)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ディナタン2D★★:おやすみなさい<br>兄さん
	Talk(Actor005,"CHRNAME_DINATAN2","speech","L","MA_01C900_290033")

-- ▼直接出力
CloseTalkWindow()
hide_image(0.3)
wait_time(1.5)
on_active(Ef_C_Adv_Dust01)
play_particle(Ef_C_Adv_Dust01)
on_active(Ef_C_Adv_Flare01)
play_particle(Ef_C_Adv_Flare01)
wait_time(0.5)
-- ▲直接出力

	--★★ディナタン2D★★:ねえ、声が聞こえない？
	Talk(Actor005,"CHRNAME_DINATAN2","speech","L","MA_01C900_290035")

	change_face(Actor004,"Surprise")

	--★★ノワール2D★★:声だって？<br>どこから？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C900_290036")


	--★★ディナタン2D★★:あっちのほう…ほら
	Talk(Actor005,"CHRNAME_DINATAN2","speech","L","MA_01C900_290037")

	change_face(Actor004,"Normal")

	--★★ノワール2D★★:…歌？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C900_290038")


	--★★ディナタン2D★★:そう、歌が聞こえる…
	Talk(Actor005,"CHRNAME_DINATAN2","speech","L","MA_01C900_290039")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
on_active(Ef_F13)
play_particle(Ef_F13)
on_active(FX_Glitch)
on_active(Ef_C_Adv_BalNoiz04_L_Lop)
play_particle(Ef_C_Adv_BalNoiz04_L_Lop)
wait_time(0.6)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ノワール2D★★:…そんなこと信じられない
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C900_290041")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
--on_active(FX_Refractive)
--set_postprocess_weight(FX_Refractive, 1.0)
--on_active(FX_Distortion)
-- ▲直接出力

	--★★テロップ★★:あなたは忘れてしまう
	Talk(Actor003,"telop","narration","L","MA_01C900_290042")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + 0.5)
--off_active(FX_Refractive)
--off_active(FX_Distortion)
off_active(FX_Glitch)
off_active(Ef_F13)
off_active(Ef_C_Adv_Dust01)
off_active(Ef_C_Adv_Flare01)
off_active(Ef_C_Adv_BalNoiz04_L_Lop)
Appear(Actor001)
Appear(Actor002)
reserve_eyesync(Actor001,"Close")
change_face(Actor001, "Normal")
change_face(Actor002, "Shy")
setup_small_camera_start(CUT_13)
set_chara_pos_resetting(Actor001,CharaPos114101_02_003)
set_chara_pos_resetting(Actor002,CharaPos114101_02_003)
PlayActionDirect(Actor001,"to Sleep02")
PlayActionDirect(Actor002,"to kiss01_Loop")
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ディナタン_1★★:だとしたら、私――<br>ねえ、兄さん、私、私ね…
	Talk(Actor002,"CHRNAME_DINATAN2","speech","N","MA_01C900_290043")

-- ▼直接出力
CloseTalkWindow()
wait_time(2.0)
PlayActionDirect(Actor002,"to kiss02_Loop")
setup_small_camera_start(CUT_14)
wait_time(0.5)
fadeout(255,255,255,1.0,1.0)
wait_time(1.0)
Hide(Actor001)
Hide(Actor002)
setup_small_camera_start(CUT_09)
wait_time(1.0)
fadein(0.2)
on_active(Ef_F15)
play_particle(Ef_F15)
wait_time(3.0)

-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField_MA_01C900_29_1", false)
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField_MA_01C900_29_2", false)
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField_MA_01C900_29_3", false)
set_object_preload("content_model_weapon_01_swd_wpn_01_swd_015", "Wpn_01_swd_015", true)
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010140_1", "content_still_10101014_image", "101010140_StillImage")
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Holy_Grail_ForcefulLight",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BalNoiz01_L_Lop",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flash_White04",false,true)
load_postprocess_preload("content_adv_postprocess_refractive", "Ef_C_PP_Refractive", false)
load_postprocess_preload("content_adv_postprocess_glitch", "Ef_C_PP_Glitch", false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_Distortion", false, true)
preload_sound("BGM_ADV_Sing_Forest")
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Dust01",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Flare01",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_BalNoiz04_L_Lop",false,true)
load_ui_effect_preload("content_still_10104026_anim", "10104026_StillAnim", nil, nil, nil, "Root")
	InitializeLoad_Preload()
	load_area_scene_preload(114101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","002","101012002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_2DOnly_Preload("101012","002","101012002")
	system.PreLoadRequest(CameraAssetBundleName114101_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
