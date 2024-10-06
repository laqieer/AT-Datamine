-- このluaスクリプトは、EA_069_052.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera002 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera003 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera005 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera006 = SetTemplate("Actor008",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera007 = SetTemplate("Actor009",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera008 = SetTemplate("Actor010",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
prop1 = set_object("content_model_weapon_98_emy_wpn_emy_001_01_swd", "Wpn_01_Emy_001_01_swd", false)
on_parent(prop1 ,Actor007,"Loc_weapon_constrint_R",{0,0,0,0,0,0})
turn_lookat(Actor008,Actor007,0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
Hide(Actor005)
Hide(Actor008)
Hide(Actor010)
Hide(Actor009)
turn_lookat(Actor001,Actor007,0)
turn_lookat(Actor003,Actor007,0)
turn_lookat(Actor007,Actor001,0)
-- ▲直接出力
-- ▼直接出力
Ef_C_Adv_VibesAura01 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura",false,true)
Ef_C_Adv_VibesAura02 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_VibesAura",false,true)
Ef_C_Adv_Emblem0201 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem02",false)
Ef_C_Adv_Emblem0202 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem02",false)
-- ▲直接出力
-- ▼直接出力
set_pos(Ef_C_Adv_VibesAura01, {-1.097, 0, 0.446})
set_pos(Ef_C_Adv_VibesAura02,{-1.868, 0, -0.062}	)
-- ▲直接出力
-- ▼直接出力
off_active(Ef_C_Adv_VibesAura01)
off_active(Ef_C_Adv_VibesAura02)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Revenge")
load_sound("BGM_Battle_Running")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101040011)
	Actor001 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_TextOnly()
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","005","101020005","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_2DOnly("101010","001","101010001")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101016","002","101016002","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor010")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Std_Squareoff_Loop")
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:…！こっちにもいたなんて――
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520002")

	open_select_window_tag(Actor001,"Normal","EA_069_0520004","EA_069_0520005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:別の逃げ道は――…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520008")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0024")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:駄目、一本道みたい…！<br>どうしよう…！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520009")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0021")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:…！
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:（引き返してみる…？<br>もしかして、状況が変わっていたり…）
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","mind","L","EA_069_0520013")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:（…駄目そうね）
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","mind","L","EA_069_0520015")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:…あの子たち、大丈夫かな
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520016")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:お姉ちゃん…！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520018")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ギネマウア★★:大丈夫。授業で学んだでしょう？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520019")

	change_face(Actor001,"Normal")

	--★★ギネマウア★★:キラーズ因子を持つ者なら<br>この程度はGSしていなくても戦えるはず
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:…あなたは私の後ろにいて
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520021")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
wait_time(0.3)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:――ハアアアッ！
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","N","EA_069_0520022")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
fadeout(255,255,255,1.0,0.1)
se_play("SE_ADV_MA_01108_12_Flight")
wait_time(0.1)
fadein(0.1)
wait_time(0.2)
fadeout(255,255,255,1.0,0.1)
wait_time(0.1)
fadein(0.1)
wait_time(0.2)
fadeout(255,255,255,1.0,0.1)
wait_time(0.1)
fadein(0.1)
wait_time(0.2)
fadeout(255,255,255,1.0,0.1)
wait_time(0.1)
fadein(0.1)
wait_time(0.2)
fadeout(255,255,255,1.0,0.1)
wait_time(0.1)
fadein(0.1)
wait_time(0.2)
fadeout(255,255,255,1.0,0.1)
wait_time(0.1)
fadein(0.1)
wait_time(0.2)
fadeout(255,255,255,1.0,0.1)
wait_time(0.1)
fadein(0.1)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0044")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ギネマウア★★:うっ…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520026")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
hide_image(BLACK_WHITE_TIME)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:お姉ちゃん、さっきの怪我が――
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520027")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Laugh")

	--★★ギネマウア★★:これくらいたいしたことないわ<br>心配しないで
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520028")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:でも…！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★ギネヴィア★★:わたしも――わたしも戦う！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520030")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0018")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:駄目よ。妹を守るのは姉の務め<br>あなただけはなにがあろうと守り抜く
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520031")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
CloseTalkWindow()
wait_time(1.4)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
bgm_play("BGM_ADV_Revenge")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:――もう二度と<br>大切なものを失うわけにはいかないから
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:お姉ちゃん…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ギネマウア★★:必ず…ふたりで里帰りするんだもんね
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520034")

	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:…！お姉ちゃん…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520035")

	change_face(Actor001,"Sad")

	--★★ギネマウア★★:本当はわかってたわ<br>どうしてあなたがあんなに頑張るのか
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520036")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:それが今はまだ難しいことも知っていて<br>でもあなたの気持ちも痛いほど理解できるから
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520037")

	change_face(Actor001,"Sad")

	--★★ギネマウア★★:だからなにも言えなくて――…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")

	--★★ギネマウア★★:そのせいで、あなたをひとりで戦わせてしまった<br>４ヶ月も
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520039")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:お姉ちゃん…
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520040")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ギネマウア★★:本当は、ちゃんと――<br>ふたりで、話すべきだったね
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:…！！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","EA_069_0520042")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:（ああ、そっか）
	Talk(Actor003,"CHRNAME_GUINEVERE","mind","L","EA_069_0520043")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:（わたしが布団被って拗ねてたから<br>見えてなかっただけで）
	Talk(Actor003,"CHRNAME_GUINEVERE","mind","L","EA_069_0520044")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:（お姉ちゃん、ずっと隣にいてくれてたんだ）
	Talk(Actor003,"CHRNAME_GUINEVERE","mind","L","EA_069_0520045")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
fadeout(255,255,255,1.0,0.6)
wait_time(0.6)
wait_time(0.4)
Hide(Actor003)
Hide(Actor001)
Hide(Actor007)
setup_small_camera_start()
Appear(Actor004)
Appear(Actor005)
wait_time(0.6)
fadein(FADE_TIME)
wait_time(FADE_TIME)
wait_time(1.2)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101020_sp_0002_1")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マーリン★★:アーサー様、こっちです！
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0520048")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0030")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★アーサー★★:…！あれは――…
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","EA_069_0520051")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start()
wait_time(0.6)
PlayActionDirect(Actor005,"to Run")
turn_chara(Actor005,10,0.4)
wait_time(0.4)
lookat_weight_reset(Actor005)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.8)
lookat_weight_reset(Actor004)
PlayActionDirect(Actor004,"to Run")
turn_chara(Actor004,10,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(1.2)
PlayActionDirect(Actor004,"to  Std_Surp")
wait_time(1.8)
fadeout(255,255,255,1.0,0.6)
wait_time(0.6)
wait_time(0.3)
Appear(Actor010)
Appear(Actor009)
Appear(Actor007)
Hide(Actor004)
Hide(Actor005)
wait_time(0.3)
fadein(FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_end()
setup_small_camera_start(Camera001)
wait_time(0.3)
on_active(Ef_C_Adv_VibesAura01)
play_particle(Ef_C_Adv_VibesAura01)
wait_time(1.6)
-- ▲直接出力
	change_face(Actor009,"Surprise")

	--★★ギネマウア3★★:ギネヴィア…
	Talk(Actor009,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520054")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera006)
wait_time(0.6)
PlayActionDirect(Actor009,"to Wlk")
turn_lookat(Actor009,Actor010,0.4)
wait_time(0.4)
PlayActionDirect(Actor009,"to Std_Loop")
wait_time(0.6)
effect_at_character(Actor009,"Chest",Ef_C_Adv_Emblem0201,0.0,0.0,0.0)
on_active(Ef_C_Adv_Emblem0201)
wait_time(1.6)
setup_small_camera_start(Camera002)
on_active(Ef_C_Adv_VibesAura02)
play_particle(Ef_C_Adv_VibesAura02)
wait_time(1.2)
effect_at_character(Actor010,"Chest",Ef_C_Adv_Emblem0202,0.0,0.0,0.0)
on_active(Ef_C_Adv_Emblem0202)
wait_time(1.4)
PlayActionDirect(Actor010,"to  Std_Joy")
wait_time(2.4)
fadeout(255,255,255,1.0,1.2)
wait_time(1.2)
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor009,"Normal")

	--★★ギネマウア3★★:…！これは――
	Talk(Actor009,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520062")

	change_face(Actor010,"Surprise")

	--★★ギネヴィア2★★:ウソ…！これって、もしかして…！<br>でも、なんで――
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:GSは絆の力<br>そう簡単に為せるものではありません
	Talk(Actor006,"CHRNAME_LANCELOT","speech","L","EA_069_0520066")


	--★★ギネヴィア2★★:…！絆の、力…
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520067")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0008")
-- ▲直接出力
	change_face(Actor010,"Laugh")

	--★★ギネヴィア2★★:…そっか、そうだよね
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520068")

	change_face(Actor010,"Smile")

	--★★ギネヴィア2★★:わたしがGSするとしたら<br>――それしかないよね
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520069")

	change_face(Actor010,"Laugh")

	--★★ギネヴィア2★★:…ごめんね、お姉ちゃん
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520070")

	change_face(Actor010,"Smile")

	--★★ギネヴィア2★★:お姉ちゃん離れ、当分ムリそう
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ギネマウア3★★:する気、あったの？
	Talk(Actor009,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520074")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0012")
-- ▲直接出力

	--★★ギネヴィア2★★:もちろん、ないけど！
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520075")

	change_face(Actor009,"Laugh")

	--★★ギネマウア3★★:やれやれ<br>でも、まぁ…おあいこかなぁ
	Talk(Actor009,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor009,"Smile")

	--★★ギネマウア3★★:私もあなたを甘やかすのを<br>やめられそうにないから
	Talk(Actor009,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0520077")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★ギネヴィア2★★:にっしっし…
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520078")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	change_face(Actor010,"Laugh")

	--★★ギネヴィア2★★:大好き、お姉ちゃん
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520079")

-- ▼直接出力
CloseTalkWindow()
bgm_play("BGM_Battle_Running")
wait_time(0.8)
-- ▲直接出力

	--★★ギネヴィア/ギネマウア★★:空より続かぬ限られし<br>いずれ地に帰す百年足らず
	Talk(Actor002,"CHRNAME_GUINEVERE_GWENHWYMAWR","speech","L","EA_069_0520080")


	--★★ギネヴィア/ギネマウア★★:汝は誰かと名を刻み<br>我　想うが故　刃となりて
	Talk(Actor002,"CHRNAME_GUINEVERE_GWENHWYMAWR","speech","L","EA_069_0520081")


	--★★ギネヴィア/ギネマウア★★:命　<ruby=あらた>革</ruby>めよ
	Talk(Actor002,"CHRNAME_GUINEVERE_GWENHWYMAWR","speech","L","EA_069_0520082")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor010,"Normal")

	--★★ギネヴィア2★★:ギネマウア――
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520084")

	open_cutin(2,2)
	on_cutin(1,Actor003,"Laugh")
	on_cutin(2,Actor001,"Laugh")

	--★★ギネヴィア/ギネマウア★★:<ruby=ファクタライズ>因枢分解</ruby>・ロンゴミアント！
	Talk(Actor002,"CHRNAME_GUINEVERE_GWENHWYMAWR","speech","L","EA_069_0520085")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
stop_particle(Ef_C_Adv_VibesAura02)
stop_particle(Ef_C_Adv_VibesAura01)
Hide(Actor009)
Appear(Actor008)
setup_small_camera_start(RndCamera008)
wait_time(0.2)
fadeout(255,255,255,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
wait_time(0.3)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★ギネヴィア2★★:大切なものを奪われてなにもできずに<br>ただ泣いてるだけ
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520087")


	--★★ギネヴィア2★★:
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520088")

-- ▼直接出力
setup_small_camera_start(Camera005)
-- ▲直接出力
	PlayAction(Actor010,"to  Std_Talk")
	change_face(Actor010,"Smile")

	--★★ギネヴィア2★★:だってわたし、ひとりじゃないから
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520089")

	change_face(Actor010,"Normal")

	--★★ギネヴィア2★★:この先、わたしの前に立ち塞がる邪魔者全部
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","L","EA_069_0520090")

	PlayAction(Actor010,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0042")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Laugh")
	change_face(Actor010,"Laugh")

	--★★ギネヴィア2★★:――ブチ抜け　ロンゴミアント
	Talk(Actor010,"CHRNAME_GUINEVERE","speech","N","EA_069_0520091")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
wait_time(0.6)
setup_small_camera_start(Camera001)
wait_time(0.8)
PlayActionDirect(Actor008,"to  Std_Yes")
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0038")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor008,"Laugh")

	--★★ギネマウア2★★:――拝命いたしました
	Talk(Actor008,"CHRNAME_GWENHWYMAWR2","speech","N","EA_069_0520092")

	close_cutin()
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
set_object_preload("content_model_weapon_98_emy_wpn_emy_001_01_swd", "Wpn_01_Emy_001_01_swd", false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura",false,true)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_VibesAura",false,true)
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02",false)
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02",false)
preload_sound("BGM_ADV_Revenge")
preload_sound("BGM_Battle_Running")
	InitializeLoad_Preload()
	load_duel_scene_preload(101040011)
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","005","101020005","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_2DOnly_Preload("101010","001","101010001")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101016","002","101016002","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
