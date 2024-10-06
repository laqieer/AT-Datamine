-- このluaスクリプトは、CO_101014_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera004 = SetTemplate("Actor004",25,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_023_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera005 = SetTemplate("Actor005",95,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_017_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	Camera007 = SetTemplate("Actor007",-15,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Pos1 = {1.7, 0, -2}
Rot1 = {0,-40,0}
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,Pos1 )
set_rot(Actor002,Rot1 )
-- ▲直接出力
-- ▼直接出力
Pos2 = {-0.9, 0, 0.5}
Rot2 = {0,125,0}
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101010111)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401030","001","401030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401021","001","401021001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("101009","001","101009001")
	Actor009 = InitializeCharacter_2DOnly("101014","001","101014001")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:修繕用の資材は<br>あらかた運び終えました
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020002")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("王様","0036")
-- ▲直接出力

	--★★汎用王様★★:ログレスの騎士たちよ<br>協力に感謝する
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_04020003")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ところで…大きな火災があったと聞いたのですが<br>なにが原因だったんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("王様", "肯定3")
-- ▲直接出力

	--★★汎用王様★★:真偽のほどは定かではないのだが<br>巨大なドラゴンが出たらしい
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_04020005")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_ik_lookat(Actor004,Actor001, "J_Head")
lookat_delay_weight_default(Actor004, 1)
PlayPartVoice("貴族_男1", "肯定2")
-- ▲直接出力

	--★★貴族（男）②★★:夜更けにその巨大ドラゴンが飛来し<br>火の息を吐いて町の一部を焼き払った、と
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_04020006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本当に巨大なドラゴンっているのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020007")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("貴族_男1", "肯定3")
-- ▲直接出力

	--★★貴族（男）②★★:にわかには信じがたいでしょうが<br>この地には伝承もあるのですよ
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_04020008")


	--★★貴族（男）②★★:「100年に一度<br>洞窟に眠る巨大ドラゴンが目覚める」
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_04020009")


	--★★貴族（男）②★★:「怒りを鎮めるには<br>若くて美しい娘を生贄にせよ」
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_04020010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★貴族（男）②★★:我が領地で一番の美女といったら姫君です
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_04020011")

	PlayAction(Actor004,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("貴族_男1","0021")
-- ▲直接出力

	--★★貴族（男）②★★:私は幼少期から姫のお世話をしてきた身<br>姫君がドラゴンに喰われるなど堪えられない！
	Talk(Actor004,"NPCNAME_0281","speech","N","CO_101014_04020012")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("王様","0009")
-- ▲直接出力

	--★★汎用王様★★:なにかの見間違いで<br>あってほしいものだが…
	Talk(Actor005,"NPCNAME_0292","speech","N","CO_101014_04020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor001)
Hide(Actor003)
Hide(Actor005)
Hide(Actor004)
Hide(Actor006)
Appear(Actor007)
set_pos(Actor002,Pos2 )
set_rot(Actor002,Rot2 )
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.2} , 1)
keep_ik_lookat(Actor002,Actor007,"J_Head")
keep_ik_lookat(Actor007,Actor002, "J_Head")
wait_time(WAIT_TIME_SHORT)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME) 
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力

	--★★トリスタン★★:わざとらしいほどに美しい忠義心だね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020015")

	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定3")
-- ▲直接出力

	--★★市民（中年男）②★★:復興支援に来て下さった円卓の騎士というのは<br>あなた方ですかな
	Talk(Actor007,"NPCNAME_0254","speech","N","CO_101014_04020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★トリスタン★★:え？<br>ああ、うん…そうだけど
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020018")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★市民（中年男）②★★:本当にすまないのう<br>なにかお礼をせねばな
	Talk(Actor007,"NPCNAME_0254","speech","N","CO_101014_04020019")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:別に要らないよ<br>お礼が欲しくてやったわけじゃないから
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020020")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_男2", "笑い")
-- ▲直接出力

	--★★市民（中年男）②★★:ほっほ。見上げた少年じゃ
	Talk(Actor007,"NPCNAME_0254","speech","N","CO_101014_04020021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★市民（中年男）②★★:困窮のただなかにある者たちに<br>無理をさせたくない、そうお考えかもしれんが
	Talk(Actor007,"NPCNAME_0254","speech","N","CO_101014_04020022")

	PlayAction(Actor007,"to  Std_Talk")

	--★★市民（中年男）②★★:困窮のただなかにあるからこそ<br>無理をしてでも伝えたい想いがあるものじゃ
	Talk(Actor007,"NPCNAME_0254","speech","N","CO_101014_04020023")

-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定2")
-- ▲直接出力

	--★★市民（中年男）②★★:受け取ってやること<br>その想いに応えてやることも大事ではないかの
	Talk(Actor007,"NPCNAME_0254","speech","N","CO_101014_04020024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★市民（中年男）②★★:あとからお礼の品は送らせてもらいますぞ
	Talk(Actor007,"NPCNAME_0254","speech","N","CO_101014_04020026")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera008)
end
-- ▲直接出力
	PlayAction(Actor007,"to Greet_one")

	--★★市民（中年男）②★★:ではの。ほっほっほ
	Talk(Actor007,"NPCNAME_0254","speech","N","CO_101014_04020027")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor007)
set_enable_auto_lookat(Actor002,true)
setup_small_camera_start(Camera002)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール2D★★:どうしたんだ、ボケッとして
	Talk(Actor008,"CHRNAME_NOIR","speech","L","CO_101014_04020029")

-- ▼直接出力
change_face(Actor001,"Normal")
Appear(Actor001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★トリスタン★★:うわっ！？
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020030")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,95,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:なんだ、キミか…
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020032")

-- ▼直接出力
setup_small_camera_start(Camera001)
setup_small_camera_end()
wait_time(1)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101014_04020034","CO_101014_04020035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ごめん、驚かせたか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020037")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:別に<br>そういえばキミも来てたんだったね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020038")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:ボクのことなんか気にしてる暇あるの？<br>町の人にいろいろ頼まれてるでしょ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020039")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ひととおり終わったよ<br>他にできることがないか探してたんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020040")

	change_face(Actor002,"Normal")

	--★★トリスタン★★:へえ<br>意外に手際がいいじゃない
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだはないだろ<br>ここまで一緒に来たじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020043")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★トリスタン★★:忘れてたんだ<br>キミになんて興味ないし
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020044")

-- ▼直接出力
PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★トリスタン★★:っていうか、ずっとそこにいたの？<br>盗み聞きなんて、いい趣味してるね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020045")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今回の事件、近くの洞窟に眠る巨大なドラゴンの<br>仕業ってウワサがあるみたいだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020047")

-- ▼直接出力
PlayPartVoice("トリスタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★トリスタン★★:信じてるのかい、そんなウワサ？<br>キミってば、本当におめでたいアタマしてるね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020048")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★トリスタン★★:バカバカしい<br>ボクは先に帰らせてもらうよ
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020049")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera002)
end
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:キミはゆっくりしていったら？<br>町のみんなが感謝してくれてるようだしね
	Talk(Actor002,"CHRNAME_TRISTAN","speech","L","CO_101014_04020050")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to Greet_one")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、おい、トリスタン！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020052")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まったく…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020053")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:しかし、ドラゴンの仕業、ねえ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101014_04020054")

-- ▼直接出力
local trustParam = set_communication_rankup("トリスタン_コミュランク", "トリスタン_親密度")
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
Pos1 = {1.7, 0, -2}
Rot1 = {0,-40,0}
Pos2 = {-0.9, 0, 0.5}
Rot2 = {0,125,0}
	InitializeLoad_Preload()
	load_duel_scene_preload(101010111)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401025","001","401025001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401030","001","401030001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401035","001","401035001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401021","001","401021001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101009","001","101009001")
	InitializeCharacter_2DOnly_Preload("101014","001","101014001")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
