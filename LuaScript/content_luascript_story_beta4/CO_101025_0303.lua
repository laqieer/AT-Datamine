-- このluaスクリプトは、CO_101025_0303.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-65,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",-35,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
DontChangeRandomCamera(true)
prop001=setup_prop_object(10130009)
on_active(prop001)
set_pos(prop001,{0,0,0})
set_rot(prop001,{0,-10,0})
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Kneeling")
set_pos(Actor005,{-3.4,0,-3.5})
set_rot(Actor005,{0,45,0})
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001, prop001, "")
keep_ik_lookat(Actor002, prop001, "")
keep_ik_lookat(Actor003, prop001, "")
keep_ik_lookat(Actor004, prop001, "")
lookat_weight_default(Actor001)
lookat_weight_default(Actor002)
lookat_weight_default(Actor003)
lookat_weight_default(Actor004)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401042","001","401042001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力

	--★★ヴォールス★★:これか
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_03030002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ヴォールス★★:腹部以外に目立った外傷はない<br>魔物に襲われたとは思いがたいな
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_03030003")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:…内臓がすべて抜き取られている
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030005")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
set_common_look_at(Actor003,Actor002)
PlayPartVoice("ヴォールス", "驚き")
-- ▲直接出力

	--★★ヴォールス★★:内臓が抜き取られているだと？<br>クレア、もしやそれは…
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_03030007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor005)
keep_ik_lookat(Actor005,Actor003,"J_Head")
-- ▲直接出力

	--★★クレア★★:そう判断するのはまだ早いわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030008")

-- ▼直接出力
PlayActionDirect(Actor005,"to Run")
slidemove(Actor005,{-0.6,0,-0.7},1)
setup_small_camera_start()
wait_time(0.8)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
PlayPartVoice("市民中年_男2", "照れ")
-- ▲直接出力

	--★★市民（中年男）③★★:ああーっ！<br>すみません、すみません！
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030010")

-- ▼直接出力
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力

	--★★ノワール★★:あなたは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030011")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定")
-- ▲直接出力

	--★★市民（中年男）③★★:私はロンディニウムで<br>レストランを営む料理人です
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030012")


	--★★市民（中年男）③★★:ふだんは近くの森まで獲物を狩りに行くんですが<br>今、新メニューの開発が大詰めで
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030013")


	--★★市民（中年男）③★★:少しでも早く材料が欲しくて<br>街の外にいた獣で、その…
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030014")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("兵士2", "驚き")
-- ▲直接出力

	--★★市民（中年男）★★:おいおい！衛兵さんやらには連絡したのかい？<br>大事件と思われても仕方ないぞ
	Talk(Actor004,"NPCNAME_0193","speech","L","CO_101025_03030015")

	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "落胆")
-- ▲直接出力

	--★★市民（中年男）③★★:すみません…新メニュー開発に没頭しすぎて<br>まわりが見えなくなってました
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030016")


	--★★市民（中年男）③★★:これから街のみなさんに<br>経緯を説明して謝ろうと思います
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_03030019","CO_101025_03030020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたがこの獣をやったのか？<br>…どうやって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030022")

	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "驚き")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★市民（中年男）③★★:え？えーっと、それは…<br>私、実は剣の腕前にはそこそこ自信がありまして
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030023")

	change_face(Actor005,"Normal")

	--★★市民（中年男）③★★:獣くらいならチョチョイのチョイなんですよ
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030024")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…この獣にはほとんど外傷がないんだが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030025")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★市民（中年男）③★★:えええーっと…夜でしたので<br>こいつもすっかり眠ってまして。そこをブスリと
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030026")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…ハラを見せて眠ってたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030027")

	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "苦しみ")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★市民（中年男）③★★:あ、あー、どうだったかなぁ？<br>私も状況をあまり覚えてなくて
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("兵士2", "怒り")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★市民（中年男）★★:まったく人騒がせな…<br>魔物でも現れたのかと思いましたよ
	Talk(Actor004,"NPCNAME_0193","speech","L","CO_101025_03030030")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "驚き")
set_common_look_at(Actor005,Actor004)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★市民（中年男）③★★:魔物だなんてそんな！<br>私は料理人ですよ？ただの！しがない！
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030031")

	change_face(Actor005,"Normal")

	--★★市民（中年男）③★★:でも、バルバロイの目撃情報もたまに聞くし<br>たしかにこのへんも物騒になりましたよね
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030032")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to Bow")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "照れ")
lookat_delay_weight_reset(Actor005,1)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★市民（中年男）③★★:本当にご迷惑をおかけしました<br>この死体の処理は手配しておきました
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030034")


	--★★市民（中年男）③★★:他にもやらなきゃいけないことがあるので<br>私はこれで失礼します
	Talk(Actor005,"NPCNAME_0194","speech","L","CO_101025_03030035")

-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,-135,0.5)
 --slidemove(Actor005,{-6.3,0,-6.4},5)
slidemove(Actor005,{-7.2,0,-6.4},5.5)
wait_time(1)
PlayActionDirect(Actor004,"to  Std_Sad02")
lookat_delay_weight_reset(Actor004,1)
wait_time(3)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-135,0.5)
 --slidemove(Actor004,{-5.1,0,-3.6},3.5)
slidemove(Actor004,{-6.0,0,-3.6},4.0)
wait_time(1)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(2.5)
setup_small_camera_start(Camera003)
Hide(Actor005)
Hide(Actor004)
set_rot(Actor001,{0,-30,0})
set_rot(Actor002,{0,10,0})
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor001)
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力

	--★★ヴォールス★★:…どう思う？
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_03030037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_03030039","CO_101025_03030040")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひとまず<br>事件は解決したと見ていいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030042")

-- ▼直接出力
PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:本当にそう思っているのか？
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_03030043")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
set_rot(Actor001,{0,-85,0})
PlayPartVoice("クレア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:わたしの見込み違いだったかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030044")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:依頼人は納得してくれたみたいだけど<br>事件が解決したとは思えない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030046")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あの男の狩りの腕前はわからないけど<br>大イノシシを一撃で倒すのは至難の業だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030047")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それに、料理人が内蔵だけを持ち去り<br>他の部位を捨て置くのも考えにくい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
set_rot(Actor001,{0,-85,0})
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…ひとまずは合格ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030049")

-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:合格？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030050")

	goto Block2end

::Block2end::
-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ノワール、今日は付き合ってくれてありがとう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030052")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:少しでもクレアの手助けができたのなら<br>なによりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030053")


	--★★クレア★★:せっかくだし、今後のためにも<br>探偵の心得を教えてあげるわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to Finger")

	--★★クレア★★:「よく観察すること<br>そして仮説を立てること」よ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030055")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★クレア★★:およそ考えうる原因をひとつずつ潰していけば<br>答えに近づける
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030056")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そうか、勉強になるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030057")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:ヴォールス、ちょっと調べたいことがあるの<br>護衛をお願いできる？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030059")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:わかった
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_03030060")

	PlayAction(Actor002,"to Greet_one")

	--★★クレア★★:それじゃあ、また
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_03030062")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
lookat_delay_weight_reset(Actor002,1)
turn_chara(Actor002,-90,0.5)
slidemove(Actor002,{-2.1,0,-1},1.5)
wait_time(0.3)
PlayActionDirect(Actor003,"to Wlk")
lookat_delay_weight_reset(Actor003,1)
turn_chara(Actor003,-90,0.5)
slidemove(Actor003,{-2.8,0,0.7},2.5)
wait_time(2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Surp")
turn_chara(Actor001,-60,0.3)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？<br>あ、ああ…またな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_03030064")

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
setup_prop_object_preload(10130009)
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401042","001","401042001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
