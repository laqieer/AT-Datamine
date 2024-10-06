-- このluaスクリプトは、CO_101011_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
Hide(Actor002)
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Ef_Emblem01 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false)
Ef_Emblem02 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false)
Ef_Emblem03 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
set_pos(Ef_Emblem03,{-1.129,0,0.488})
Ef_Emblem04 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
set_pos(Ef_Emblem04,{1.294,0,0.66})
Ef_Emblem05 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
set_pos(Ef_Emblem05,{-1.129,0,0.488})
Ef_Emblem06 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
set_pos(Ef_Emblem06,{1.294,0,0.66})
Ef_Emblem07 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false)
Ef_Emblem08 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
set_pos(Ef_Emblem08,{0.865,0,-0.158})
Ef_Emblem09 =  set_object("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false)
Ef_Emblem10 =  load_particle("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
set_pos(Ef_Emblem10,{1.294,0,0.66})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","002","101016002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:約束してる相手って<br>ギネマウアさんだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_06020002")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア2★★:わたしは<br>あなたのキラーズになったでしょ？
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","CO_101011_06020004")


	--★★ギネヴィア2★★:キラーズの先輩であるお姉ちゃんに
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","CO_101011_06020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア2★★:キラーズとしての戦いかたとか<br>心構えを教えてもらおうと思って
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","CO_101011_06020006")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力

	--★★ギネマウア2★★:わざわざすみません<br>ノワール様
	Talk(Actor005,"CHRNAME_GWENHWYMAWR","speech","L","CO_101011_06020007")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア2★★:じゃ、始めましょ
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","CO_101011_06020008")


	--★★ギネヴィア2★★:ギネマウア――<br>因枢分解・ロンゴミアント！
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","CO_101011_06020009")

-- ▼直接出力
CloseTalkWindow()
effect_at_character(Actor004, "Chest", Ef_Emblem02, 0.0, 0.15, 0.0)
effect_at_character(Actor005, "Chest", Ef_Emblem01, 0.0, 0.15, 0.0)
on_active(Ef_Emblem03) --キラーズ化エフェクト再生
play_particle(Ef_Emblem03)
on_active(Ef_Emblem06) --キラーズ化エフェクト再生
play_particle(Ef_Emblem06)
wait_time(2.3)
on_active(Ef_Emblem05)
play_particle(Ef_Emblem05)
wait_time(0.5)
fadeout(255,255,255,1,0.5)
wait_time(0.5)
Hide(Actor005)
Appear(Actor003)
wait_time(0.5)
fadein(0.5)
wait_time(1.0)
off_active(Ef_Emblem01)
off_active(Ef_Emblem07)
stop_particle(Ef_Emblem03)
stop_particle(Ef_Emblem05)
stop_particle(Ef_Emblem06)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★ギネヴィア2★★:さ、ノワール<br>次はわたしを因枢分解して
	Talk(Actor004,"CHRNAME_GUINEVERE","speech","L","CO_101011_06020011")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった。ギネヴィア――<br>因枢分解・アロンダイト！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_06020012")

-- ▼直接出力
CloseTalkWindow()
effect_at_character(Actor004, "Chest", Ef_Emblem07, 0.0, 0.15, 0.0)
effect_at_character(Actor001, "Chest", Ef_Emblem09, 0.0, 0.15, 0.0)
on_active(Ef_Emblem04) --キラーズ化エフェクト再生
play_particle(Ef_Emblem04)
on_active(Ef_Emblem08) --キラーズ化エフェクト再生
play_particle(Ef_Emblem08)
wait_time(2.3)
on_active(Ef_Emblem10)
play_particle(Ef_Emblem10)
wait_time(0.5)
fadeout(255,255,255,1,0.5)
wait_time(0.5)
Hide(Actor004)
Appear(Actor002)
wait_time(0.5)
fadein(0.5)
wait_time(1.0)
off_active(Ef_Emblem02)
off_active(Ef_Emblem09)
stop_particle(Ef_Emblem04)
stop_particle(Ef_Emblem08)
stop_particle(Ef_Emblem10)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ギネマウア★★:授業でも習ったと思いますが
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:キラーズとマスターの戦闘能力は<br>お互いの本来の力の乗算となります
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020015")


	--★★ギネマウア★★:私とGSを果たしたあと<br>ノワール様ともGSを果たした今
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネマウア★★:あなたは以前の数倍強くなっているはず
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020018")

	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★ギネマウア★★:…手加減なしでいきます！
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","N","CO_101011_06020019")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★ギネヴィア★★:負けないから<br>お姉ちゃん！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","N","CO_101011_06020020")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
close_cutin()
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
se_play("SE_ADV_MA_01106_12_Spear_Whoosh")
wait_time(0.5)
se_play("SE_ADV_MA_01C111_21_Sword")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネマウア", "気合い")
-- ▲直接出力

	--★★ギネマウア★★:踏み込みが甘い！
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020022")


	--★★ギネマウア★★:扱う武器が変わったのだから<br>自分の得意とする間合いを理解なさい！
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020023")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "苦しみ")
-- ▲直接出力

	--★★ギネヴィア★★:う、うん！<br>わかった！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020024")

-- ▼直接出力
se_play("SE_ADV_MA_01106_12_Spear_Whoosh")
wait_time(0.5)
se_play("SE_ADV_MA_01C111_21_Sword")
-- ▲直接出力

	--★★ギネマウア★★:正面ばっかり見ない！<br>空を飛ぶバルバロイだっているのよ！
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020026")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:そ、そんなこと言ったって<br>頭が追い付かないよぉ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020027")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
setup_small_camera_end()
SkipDefaultMotion(Actor002)
set_animationbattlecontroller(Actor002,1,true)
PlayActionDirect(Actor002,"ToAbnormal")
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:はぁ、ふぅ…<br>ほんと、弱っちくてイヤになる…
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020029")

	open_select_window_tag(Actor001,"Normal","CO_101011_06020031","CO_101011_06020032")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:よく頑張ったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_06020034")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キラーズとしての戦いかた<br>だいぶ板についてきたんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_06020035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:まだまだお姉ちゃんには<br>ぜんぜんかなわないよ
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020036")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:さすがはギネマウアさんだ<br>強くなったはずのギネヴィアを終始圧倒してた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_06020038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネマウア★★:これでもキラーズとして<br>ある程度研鑽を積んできたつもりですから
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020039")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:やっぱりお姉ちゃんには<br>かなわないなぁ～
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020040")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしがノワールの<br>キラーズとして戦ってるときも
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:ピンチになったら<br>助けてね、お姉ちゃん！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020043")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:キラーズになっても<br>甘えん坊は変わらずなんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101011_06020045")

-- ▼直接出力
PlayPartVoice("ギネヴィア", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:大きなお世話！
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020046")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★ギネマウア★★:ピンチになったとき<br>あなたは助けてもらうのではなく
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020048")

-- ▼直接出力
PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力

	--★★ギネマウア★★:命を落とす覚悟で<br>マスターを守らなければならないのよ
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020049")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ん、なあに？<br>なにか言った、お姉ちゃん？
	Talk(Actor002,"CHRNAME_GUINEVERE2","speech","L","CO_101011_06020050")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020051")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネマウア★★:ふたり、仲がいいわね、って
	Talk(Actor003,"CHRNAME_GWENHWYMAWR2","speech","L","CO_101011_06020053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ギネヴィア_コミュランク", "ギネヴィア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false)
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem02", false)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Lop",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem01", false)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_VibesAura",false,true)
set_object_preload("content_effect3d_common_adv", "Ef_C_Adv_Emblem21", false)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Killers_Cancel",false,true)
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","002","101011002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","002","101016002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
