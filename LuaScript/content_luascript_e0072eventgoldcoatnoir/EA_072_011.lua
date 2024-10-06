-- このluaスクリプトは、EA_072_011.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-70,CharaPos114031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_006)
	Camera002 = SetTemplate("Actor003",-130,CharaPos114031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_009_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_004)
	Camera003 = SetTemplate("Actor004",85,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera004 = SetTemplate("Actor005",62,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera005 = SetTemplate("Actor006",nil,CharaPos114031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_007)
	Camera006 = SetTemplate("Actor008",nil,CharaPos114031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_004)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
load_image("101030190","content_still_10103019_image","101030190_StillImage")
load_image("101010140","content_still_10101014_image","101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
show_image("101030190", 0.0, 0.0, 0.8,true,true)
set_scale_image(0.7,0.7)
-- ▲直接出力
-- ▼直接出力
Hide(Actor001)
Hide(Actor008)
change_face(Actor003,"Anger")
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
Sword_05 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
off_parent(Sword_05,Actor001, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
Sword_01 = set_object("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
off_parent(Sword_01,Actor004, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
Axe_01 = set_object("content_weapon_102020001", "weapon_model_102020001", true)
weapon_offset = {0,0,0,0,0,-5}
off_parent(Axe_01 ,Actor005, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
bow_01 = set_object("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,-5}
off_parent(bow_01,Actor006, "Loc_weapon_constrint_L",weapon_offset)
-- ▲直接出力
-- ▼直接出力
off_active(Sword_05)
on_parent(Sword_05,Actor001, "Loc_weapon_constrint_R",weapon_offset)
on_parent(Sword_01,Actor004, "Loc_weapon_constrint_R",weapon_offset)
on_parent(bow_01,Actor005, "Loc_weapon_constrint_L",weapon_offset)
on_parent(Axe_01,Actor006, "Loc_weapon_constrint_R",weapon_offset)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{0.3,-0.40,3.6})
set_pos(Actor004,{-0.6,-0.381,3.4})
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Meeting")
load_sound("BGM_ADV_Invation3")
load_sound("BGM_Battle_Noir")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_2DOnly("101009","009","101009009")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401038","001","401038001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	Actor008 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_2DOnly("101009","009","101009009")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera001)
wait_time(0.7)
-- ▲直接出力

	--★★ノワール★★:もしまだここに、キミがいたなら
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0110002")


	--★★ノワール★★:「見ろよ。すごい景色だなあ」<br>「旅先ではどんな食べ物がおいしいんだろう」
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0110003")


	--★★ノワール★★:なにを言うだろうか<br>きらきら笑うだろうか
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0110004")


	--★★ノワール★★:想像するしかなくなってく<br>だんだんとわからなくなってく
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0110005")


	--★★ノワール★★:ふたりでいたら<br>どこへいくだろうか
	Talk(Actor001,"CHRNAME_NOIR","simple","N","EA_072_0110006")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
hide_image(0)
--フェードイン
wait_time(2)
bgm_play("BGM_ADV_Meeting")
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.2)
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力

	--★★カレドニア兵A★★:我らカレドニアとの密約を<br>反故にしたローマ皇太子ルーシャスは死んだ！
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0110010")


	--★★カレドニア兵A★★:円卓の騎士擁するログレスは<br>ローマ軍との戦いでもはや手負いである！
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0110011")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("兵士1","0011")
-- ▲直接出力

	--★★カレドニア兵B★★:アストラット郷の民どもよ！<br>ログレスの応援は間に合わぬ！抵抗は無意味だ！
	Talk(Actor005,"NPCNAME_0398","speech","N","EA_072_0110012")


	--★★不安げな市民★★:………ラヴェイン様<br>いかがいたしましょう…？
	Talk(Actor007,"NPCNAME_0340","speech","L","EA_072_0110013")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ラヴェイン★★:…カレドニアの兵たち<br>要求はなんです
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_072_0110014")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★カレドニア兵A★★:新たなるカレドニアに<br>この地を明け渡せ
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0110015")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力

	--★★ラヴェイン★★:………
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_072_0110016")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ラヴェイン★★:要求は聞き入れられません
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_072_0110017")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0002")
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力

	--★★カレドニア兵A★★:やれ。皆殺しだ
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0110018")

-- ▼直接出力
setup_small_camera_start(Camera006)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0043")
PlayActionDirect(Actor003,"to Std_Squareoff_Loop")
SkipDefaultMotion(Actor003)
bgm_play("BGM_ADV_Invation3")
-- ▲直接出力

	--★★ラヴェイン★★:民たちはキャメロットへ避難を…！敵が多い、ここは私が──
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_072_0110019")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("兵士1","0002")
-- ▲直接出力

	--★★カレドニア兵B★★:そこの騎士は後回しにしろ<br>まずは民どもだ
	Talk(Actor005,"NPCNAME_0398","speech","N","EA_072_0110020")

-- ▼直接出力
PlayPartVoiceDirect("ラヴェイン","0015")
PlayActionDirect(Actor003,"to  Std_Surp")
SkipDefaultMotion(Actor003)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラヴェイン★★:ま、待ってください…！！
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","EA_072_0110021")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
PlayPartVoiceDirect("ノワール","0017")
-- ▲直接出力

	--★★？？？★★:こっちだ
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","EA_072_0110023")

	open_cutin(1,2)
	on_cutin(1,Actor003,"Surprise")

	--★★ラヴェイン★★:！？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","N","EA_072_0110024")

	close_cutin()

	--★★？？？★★:カレドニア王ライエンスを倒したのは俺だ<br>俺を狙え
	Talk(Actor002,"CHRNAME_NAMELES","speech","L","EA_072_0110025")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("兵士1","0028")
-- ▲直接出力

	--★★カレドニア兵B★★:…！？<br>まさか──
	Talk(Actor005,"NPCNAME_0398","speech","N","EA_072_0110026")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
fadeout(0,0,0,0.2, 0.5)
wait_time(0.5)
show_image("101010140", 0.0, 0.0, 0.8,true,true)
set_scale_image(20,20)
set_animationbattlecontroller(Actor004, 1,false)
set_animationbattlecontroller(Actor005, 8,false)
set_animationbattlecontroller(Actor006, 4,false)
turn_chara(Actor003,-178,0.2)
turn_chara(Actor004,160,0.2)
turn_chara(Actor005,140,0.2)
turn_chara(Actor006,172,0.2)
fadein(0.2)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Noir")
Appear(Actor001)
on_active(Sword_05)
se_play("SE_ADV_MA_01106_01_Footstep")
-- ▲直接出力

	--★★ノワール2★★:我こそは『<ruby=ラ・コート・マルタイユ>不格好なコート</ruby>』──
	Talk(Actor009,"CHRNAME_NOIR","speech","L","EA_072_0110028")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
fadeout(0,0,0,0.2, 0.5)
wait_time(0.5)
hide_image(0.5)
wait_time(0.3 + 0.2)--0.6秒+0.5秒
fadein(0.2)
wait_time(0.5)
-- ▲直接出力

	--★★カレドニア兵A★★:継承者…！？
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0110030")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:ブルーノ・ル・ノワール
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0110031")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("山賊","0032")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor006,"Normal")

	--★★カレドニア兵A★★:う、討ち取れ！！<br>なんとしても全員で止めろ！！
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0110032")


	--★★カレドニア兵A★★:継承者の首を取ったとなれば<br><dot>あの御方</dot>もお喜びになる！
	Talk(Actor004,"NPCNAME_0397","speech","N","EA_072_0110033")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	close_cutin()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力

	--★★ノワール★★:…変わらないな、いつまでも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0110037")


	--★★ノワール★★:外には怪物、日々は地獄だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_072_0110039")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_Handling_Swd_001")
PlayActionDirect(Actor001,"to Std_Squareoff_Loop")
SkipDefaultMotion(Actor001)
wait_time(0.7)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101030190","content_still_10103019_image","101030190_StillImage")
load_image_preload("101010140","content_still_10101014_image","101010140_StillImage")
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
set_object_preload("content_weapon_101010001", "weapon_model_101010001", true)
weapon_offset = {0,0,0,0,0,0}
set_object_preload("content_weapon_102020001", "weapon_model_102020001", true)
weapon_offset = {0,0,0,0,0,-5}
set_object_preload("content_weapon_105010001", "weapon_model_105010001", true)
weapon_offset = {0,0,0,0,0,-5}
preload_sound("BGM_ADV_Meeting")
preload_sound("BGM_ADV_Invation3")
preload_sound("BGM_Battle_Noir")
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_2DOnly_Preload("101009","009","101009009")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401038","001","401038001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_2DOnly_Preload("101009","009","101009009")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
