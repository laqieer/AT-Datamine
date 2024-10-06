-- このluaスクリプトは、CO_101030_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_005)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
tegami = setup_prop_object(10106003)
off_active(tegami)
tegami_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor002,Actor003,"J_Head")
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003, 0.6, -0.232, 2.7, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）②★★:ぼくにお手紙？
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:そう<br>ロンディニウムのみんなから預かってきたの
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020003")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("子供_男2", "喜び")
-- ▲直接出力

	--★★子供（男）②★★:みんなから！？<br>うわぁ、うれしいなあ！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:トビーくんに会いたいっていう子も<br>大勢いたんだけれど
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020005")

-- ▼直接出力
PlayPartVoice("エレイン", "悩む")
-- ▲直接出力

	--★★エレイン★★:ロンディニウムからこの村まで移動するのは<br>ちょっと危ないから。手紙で我慢してもらったの
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020006")


	--★★子供（男）②★★:そうなんだ、残念…
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020007")

-- ▼直接出力
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）②★★:でも…ぼく、まだ目がよく見えないから<br>お手紙もらっても読めないよ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:私が読んであげる
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020009")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("子供_男2","0012")
-- ▲直接出力

	--★★子供（男）②★★:本当！？<br>やったぁ、早く読んで早く読んで！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020010")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
on_parent(tegami,Actor002, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to ReadLetter")
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(0.7)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:「お前がいなくなっちゃって<br>みんな寂しがってるぞ」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020012")


	--★★エレイン★★:「早く元気になってもどってきて<br>かくれんぼをまた一緒にやろうな」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:ほかにもたくさんあるのよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020015")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "喜び")
-- ▲直接出力

	--★★子供（男）②★★:ありがとう、お姉ちゃん
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020017")


	--★★子供（男）②★★:ぼく、早く元気になりたい<br>ロンディニウムのみんなと遊びたいよ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:私もお手紙を書いてきたんだけど<br>聞いてくれる？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020020")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:ぼくに？<br>もちろんだよ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:「トビーくんへ」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020023")


	--★★エレイン★★:「ずっと一緒にいてあげられなくてごめんなさい」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020024")


	--★★エレイン★★:「さみしいでしょうけど<br>心細いでしょうけど」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020025")


	--★★エレイン★★:「ロンディニウムにいた頃と同じように明るく、元気に過ごしてください」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020026")


	--★★エレイン★★:「あなたの目の前の暗闇はきっと払われるから」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★エレイン★★:「強くてかっこいい円卓の騎士様がいつか手を差し伸べてくれるから」
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020028")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6)
wait_time(0.9)
off_parent(tegami)
off_active(tegami)
PlayActionDirect(Actor002,"to Std_Loop")
--フェードイン
fadein(0.6)
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）②★★:本当に円卓の騎士が助けてくれるの？
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_06020032","CO_101030_06020033")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろんだ円卓の騎士のひとり、ノワールが約束する
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020035")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男2","0029")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:えっ！？お兄ちゃん、円卓の騎士なの！！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020036")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だから今はみんなのことをよく聞いてゆっくり体を休めるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:うん、わかったよ！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020038")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん、どうかなあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020040")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:せっ、先輩っ！？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020041")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:冗談だよ、エレイン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、きっと助けてくれる円卓の騎士は子供の味方だからな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020043")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★子供（男）②★★:わかった！ぼく、大人しくしているよ！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_06020045")

	goto Block1end

::Block1end::
-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera004)
end
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民中年_男2", "肯定")
-- ▲直接出力

	--★★市民（中年男）★★:エレイン様それでは今日はこのへんで失礼します
	Talk(Actor004,"NPCNAME_0272","speech","L","CO_101030_06020047")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
se_play("SE_ADV_CO_101030_0303_Foot_2_Peaple")

Hide(Actor004)
Hide(Actor003)
set_enable_auto_lookat(Actor002,false)
set_enable_auto_lookat(Actor001,false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
turn_chara(Actor001,180,0)

setup_small_camera_start()
wait_time(1.1)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101030_06020049","CO_101030_06020050")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:トビー、すごく喜んでた良かったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:はい先輩もありがとうございました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020053")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はなにもやってないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020054")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★エレイン★★:最後に円卓の騎士が助けてくれるって言ってくれたじゃないですか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020055")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:あれは、まあ…騎士として当然の行為をしたまでだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020057")

-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:ふふっ、そうですね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020058")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ちょっとカッコつけすぎちゃったかなぁ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020060")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:そんなことないですよそもそも先輩はカッコい…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020061")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Shy")

	--★★エレイン★★:い、いえ！トビーくん、すごく喜んでましたし
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020062")

	change_face(Actor002,"Surprise")

	--★★エレイン★★:あのくらいでちょうど良かったと思いますよ！ちょうど良かったと！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020063")

	goto Block2end

::Block2end::
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それじゃ、また機会を見て手紙を持って来てやろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_06020065")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:はい。ロンディニウムの子供たちにもトビーくんが喜んでいたと伝えてあげないと
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_06020066")

-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
