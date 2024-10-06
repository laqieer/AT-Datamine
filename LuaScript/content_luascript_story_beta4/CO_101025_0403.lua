-- このluaスクリプトは、CO_101025_0403.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera003 = SetTemplate("Actor003",165,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
set_rot(Actor001,{0,140,0})
set_rot(Actor003,{0,170,0})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor004,true)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
lookat_weight_default(Actor001)
lookat_weight_default(Actor002)
lookat_weight_default(Actor003)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_001)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）②★★:そのおじさんなら見たよ
	Talk(Actor004,"NPCNAME_0077","speech","L","CO_101025_04030002")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本当か！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:うん。裏通りで遊んでたときにね<br>魔法道具屋さんから出てきたの
	Talk(Actor004,"NPCNAME_0077","speech","L","CO_101025_04030004")

	PlayAction(Actor004,"to  Std_Talk")

	--★★子供（男）②★★:「ログレスのガキどもで実験してやる」<br>って怖いこと言ってたから、よく覚えてる
	Talk(Actor004,"NPCNAME_0077","speech","L","CO_101025_04030005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:魔法道具屋に行ってみましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030006")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Run")
lookat_delay_weight_reset(Actor002,1)
turn(Actor002,0,180,0,0.3)
slidemove(Actor002,{-0.7,0,-5.8},2)
wait_time(1)
PlayActionDirect(Actor003,"to Run")
lookat_delay_weight_reset(Actor003,1)
turn(Actor003,0,180,0,0.3)
slidemove(Actor003,{0.7,0,-6.7},2.5)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor003)
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,195,0.3)
-- ▲直接出力

	--★★ノワール★★:お、おい、ちょっと！<br>この子にお礼しないと…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030007")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor004)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
change_face(Actor001,"Normal")
set_enable_auto_lookat(Actor001,true)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
template2()
set_rot(Actor001,{0,-150,0})
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:あの子にはお礼にお菓子をおごっておいたよ<br>…で、話は聞けたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ええ<br>少し前の話らしいんだけど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030010")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:あの男は一時的に魔力を高める<br>呪具を買いに来たそうよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030011")


	--★★クレア★★:ただ、店ではちょうど在庫を切らしていたから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030012")


	--★★クレア★★:手に入ったら届けるという話になって<br>男は帰って行ったみたい
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:ってことは<br>男の居場所がわかったわけか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:ああ、判明した<br>どうやらログレスに滞在しているようだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_04030015")


	--★★ノワール★★:「ログレスのガキどもで実験してやる」<br>と言っていたらしいし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030016")


	--★★ノワール★★:やっかいなことになる前に<br>見つけて話を聞いたほうがよさそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:男の欲しがっていた呪具が入荷する<br>おおよその時期を聞いてきたわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クレア★★:その前に男を見つけ出しましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030019")

-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
wait_time(1)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
turn_chara(Actor001,-130,1)
wait_time(3)
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:…わたしの顔になにかついてる？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
turn_chara(Actor001,-150,0.5)
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:いや…事件を調査しているときのクレアは<br>よく喋るし、よく走るなって思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030022")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:息をしているのかわからなくなるほど<br>長時間身動きしないこともあるからな、普段は
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_04030023")

	change_face(Actor002,"Normal")

	--★★クレア★★:「答えが近づいて来たら走れ」
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030024")


	--★★クレア★★:「間違うことを恐れるな<br>一番の恥は行動しないことだ」
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:それも、探偵の心得？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力

	--★★クレア★★:そう<br>わたしの探偵の師匠が教えてくれたの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_04030029","CO_101025_04030030")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:「よく観察すること<br>そして仮説を立てること」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030032")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「答えが近づいて来たら走れ」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:「間違うことを恐れるな<br>一番の恥は行動しないことだ」…か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030034")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺には探偵の世界はまだよくわからないけど<br>かっこいい言葉だな。素敵な師匠だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030035")

-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ふふっありがとう<br>師匠は世界一素敵な探偵よ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030036")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:クレアに探偵の言葉を教えてくれた師匠は<br>今どこでなにをしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030038")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:…ノワール
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_04030040")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…あっ！？<br>ご、ごめん…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030041")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
change_face(Actor001,"Normal")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:次はログレスでの調査ね<br>頃合いを見て連絡するわ、ノワール
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_04030043")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった<br>いつでも呼んでくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_04030044")

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
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
