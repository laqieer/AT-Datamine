-- このluaスクリプトは、CO_101025_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-50,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_002)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor003,{3.3,0,-11.5})
set_rot(Actor003,{0,80,0})
set_pos(Actor004,{4,0,-12})
set_rot(Actor004,{0,-25,0})
Hide(Actor003)
Hide(Actor004)
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight_default(Actor001)
-- ▲直接出力
-- ▼直接出力
set_chara_pos_resetting(Actor003,{0.26, -0.003, -9.68,   135})
-- ▲直接出力
-- ▼直接出力
set_chara_pos_resetting(Actor004,{1.29, -0.003, -10.24,   135})
-- ▲直接出力
-- ▼直接出力
goal1 = {3.09, -0.003, -11.586,   80.15609}
goal2 = {4.119, -0.003, -12.021,   327.2622}
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力

	--★★クレア★★:あらためてお礼を言わせてほしいの<br>ジャスパーの一件はありがとう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020002")


	--★★クレア★★:あなたの手助けがなければ<br>解決できなかった事件かもしれない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020003")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_10020005","CO_101025_10020006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どういたしまして<br>力になれたのならなによりだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020008")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:スコーンににおいを追わせる<br>…わたしにはない発想だったわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020009")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…それって<br>遠回しにバカにしてるんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020010")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
PlayPartVoice("クレア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ふふっ。そんなことないわ<br>キチンと褒めているわよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そんなことないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020013")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の力なんてなくても<br>クレアとヴォールスなら解決してた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ありがとう<br>ヴォールスも喜ぶと思うわ、そのひとこと
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020015")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ところで…<br>ひとつ気になったことがあるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020017")

-- ▼直接出力
PlayPartVoice("クレア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:なに？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020018")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:今回って<br>正式に依頼を受けたわけじゃないだろ<br>
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020019")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:せっかく事件を解決できたのに<br>報酬がもらえてないんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020020")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クレア★★:前にも言ったじゃない
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoice("クレア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:わたしの好奇心を満たしてくれた<br>それだけで十分よ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020023")

-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:！<br>ノワール、静かに
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020025")

-- ▼直接出力
IN_WALK_2P(Actor003,goal1,Actor004,goal2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
PlayPartVoice("兵士1", "怒り")
-- ▲直接出力

	--★★市民（男）★★:あの男はやはりニセモノだったか
	Talk(Actor003,"NPCNAME_0178","speech","N","CO_101025_10020027")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
change_face(Actor001,"Surprise")
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1)
PlayPartVoice("兵士2", "怒り")
-- ▲直接出力

	--★★市民（男）②★★:あの方に喜んでもらえるかもと<br>泳がせてみたが…時間の無駄だったな
	Talk(Actor004,"NPCNAME_0179","speech","N","CO_101025_10020028")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("兵士1", "否定")
-- ▲直接出力

	--★★市民（男）★★:だが、ヤツの足取りを追う手がかりくらいは<br>…おい
	Talk(Actor003,"NPCNAME_0178","speech","N","CO_101025_10020030")

-- ▼直接出力
	CloseTalkWindow()
	fadeout(0,0,0,1.0, FADE_TIME)
	wait_time(FADE_TIME)
	Hide(Actor003)
	Hide(Actor004)
	setup_small_camera_start()
	wait_time(TIME_ELAPSED)
	--フェードイン
	fadein(FADE_TIME)
	wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、あいつらはいったい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020032")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ひとつの事件の終わりは<br>あたらしい事件の始まりなのよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020033")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クレア★★:また忙しくなりそうね<br>手伝いをお願いしてもいいかしら？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろん<br>頼りになる助手にお任せあれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_10020035")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ふふっ、期待してるわよ<br>これからもよろしくね、ノワール
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_10020037")

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
goal1 = {3.09, -0.003, -11.586,   80.15609}
goal2 = {4.119, -0.003, -12.021,   327.2622}
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
