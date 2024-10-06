-- このluaスクリプトは、CO_101025_0704.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",35,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",-90,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_pos(Actor004,{-3.8,0,1})
set_rot(Actor004,{0,80,0})
set_animationbattlecontroller(Actor004,3,false)
set_animationbattlecontroller(Actor005,2,true)
set_animationbattlecontroller(Actor006,1,false)
Ef_Aura_Enemy1 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
local EfPos = get_pos(Actor004)
set_pos(Ef_Aura_Enemy1,EfPos)
Ef_Aura_Enemy2 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
local EfPos = get_pos(Actor005)
set_pos(Ef_Aura_Enemy2,EfPos)
Ef_Aura_Enemy3 = load_particle("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
local EfPos = get_pos(Actor006)
set_pos(Ef_Aura_Enemy3,EfPos)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_weight_default(Actor001)
lookat_weight_default(Actor002)
lookat_weight_default(Actor003)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401023","001","401023001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:おぼろげだけど<br>ジャスパーの動機は見えてきたわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040002")

	open_select_window_tag(Actor001,"Normal","CO_101025_07040004","CO_101025_07040005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ジャスパーはバルバロイの教団に取り入って<br>魔力を取り戻そうとしているようだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040007")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ただし、そのためには実力を示す必要がある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…自分を偽ってでも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040009")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:素晴らしいわ、ノワール
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さすがはクレアだ<br>ぜひ考えを聞かせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040012")

-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…ジャスパーはバルバロイの教団に取り入って<br>魔力を取り戻そうとしているのよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:ただし、そのためには実力を示す必要がある
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:今の自分の力ではそれが難しいと考えた<br>ジャスパーは大きな賭けに出た
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040015")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera005)
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:ジャスパーは有名な連続殺人鬼『血の蒐集家』の<br>名を騙ろうとした
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:魔法道具屋で呪物を手に入れ<br>なけなしの魔力を増幅しようとしたのだろうな
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_07040018")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:バルバロイ教団に入れたとしても<br>魔力を取り戻せる保証なんてないのに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:それでもジャスパーは飛びつかざるを得なかった
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040020")

	change_face(Actor002,"Anger")

	--★★クレア★★:今の彼は危険よ<br>魔力を取り戻すためならなんだってしかねない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040021")


	--★★クレア★★:ジョーイを手にかけることだって<br>躊躇しないでしょうね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040022")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:急いでジャスパーの行方を追おう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:そうね<br>すぐに足取りを…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040024")

-- ▼直接出力
bgm_play("BGM_ADV_Invasion2")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor004)
Appear(Actor005)
Appear(Actor006)
on_active(Ef_Aura_Enemy1) 
play_particle(Ef_Aura_Enemy1)
on_active(Ef_Aura_Enemy2) 
play_particle(Ef_Aura_Enemy2)
on_active(Ef_Aura_Enemy2) 
play_particle(Ef_Aura_Enemy2)
lookat_delay_weight_reset(Actor002,1)
lookat_delay_weight_reset(Actor003,1)
PlayActionDirect(Actor003,"to  Std_Surp")
turn_chara(Actor003,-70,0.3)
PlayPartVoice("ヴォールス", "激怒")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ヴォールス★★:クレア、ノワール、構えろ！
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_07040025")

-- ▼直接出力
setup_small_camera_start(Camera002)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_delay_weight(Actor002,0.7,0.03,0.7,0,1.5)
PlayPartVoice("クレア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:え？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040026")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor001,1)
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,-40,0.3)
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:人間…？いや、バルバロイ憑きか！<br>なんでこんなところに！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040028")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
turn_chara(Actor002,-60,1)
lookat_delay_weight_reset(Actor002,1)
change_face(Actor002,"Anger")
PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力

	--★★ヴォールス★★:考えている暇はない<br>被害が出る前に倒すぞ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_07040029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ああ、わかった！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040030")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
off_active(Ef_Aura_Enemy1)
stop_particle(Ef_Aura_Enemy1)
off_active(Ef_Aura_Enemy2)
stop_particle(Ef_Aura_Enemy2)
off_active(Ef_Aura_Enemy3)
stop_particle(Ef_Aura_Enemy3)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
set_rot(Actor001,{0,35,0})
set_rot(Actor002,{0,-90,0})
set_rot(Actor003,{0,-123,0})
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
change_face(Actor001,"Normal")
change_face(Actor002,"Anger")
change_face(Actor003,"Normal")
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor003,Actor001)
setup_small_camera_start(RndCamera006)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:どうやら、これで全部のようだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_07040032")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まさかこんな街中に現れるなんてな<br>被害が出なくてよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040033")

	change_face(Actor002,"Anger")

	--★★クレア★★:………
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
set_common_look_at(Actor001,Actor002)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:どうしたんだ、クレア<br>もしかしてどこかケガでも？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★クレア★★:いいえ。ケガはしていないわ<br>ただ、少し考えごとをしていただけ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040037")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:ともかく、今日はこれで解散しましょう<br>ジャスパーの足取りがつかめたら連絡するわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_07040038")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:あ、ああ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_07040039")

-- ▼直接出力
local trustParam = set_communication_rankup("クレア_コミュランク", "クレア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
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
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
load_particle_preload("content_effect3d_common_adv","Ef_C_Adv_Aura_Enemy_Lop",false,true)
preload_sound("BGM_ADV_Invasion2")
preload_sound("BGM_ADV_Reconnaissance")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401023","001","401023001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
