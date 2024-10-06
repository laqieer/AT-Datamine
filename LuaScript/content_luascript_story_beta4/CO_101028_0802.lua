-- このluaスクリプトは、CO_101028_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ガラハッド★★:さ、さあ、食べてくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おお！<br>きちんとクッキーの形をしてる！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そうだろう！料理のために<br>筋力制御のトレーニングをしたんだ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020005")

	change_face(Actor001,"Normal")

	--★★ノワール★★:クッキーを作るための練習として<br>それが正しいのかはわからないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:うまい！うまいよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020008")


	--★★ノワール★★:スカートでの歩きかたも自然になったし<br>本当に頑張ったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020009")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:最近ではスカートも<br>動きやすくていいと思い始めてきた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ところでさ。前から気になってたけど<br>どうしてあんなに重そうな鎧を着てるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020012")


	--★★ノワール★★:軽装の騎士だっているだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ガラハッド★★:強いだけじゃダメだ<br>逞しいだけでもダメだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020015")


	--★★ガラハッド★★:仲間に危険が及んだときは支え<br>身を挺してでも守り抜く
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:それが僕の理想とする騎士像だ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020017")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほど、立派だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020019")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:それでな<br>それで、その…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:どうしたんだ、急に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020022")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:「子供じみてる」などと笑わないでくれるか？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020024")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:身体の小さな僕が仲間を守るには大きな鎧を着るしかないと思ったんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_08020027","CO_101028_08020028")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:理想とする騎士像に近づくためなんだろ？熱いじゃないか、素敵じゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020030")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それを笑うヤツなんていないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:そ、そうか！ありがとう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020032")

-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:これまでの自分が肯定してもらえたようですごく嬉しい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドの気持ち、わかる気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020035")

	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が金色のコートを羽織っている理由も似たようなものだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020036")

-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ノワールも…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020038")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:よかったらコートを羽織る理由を教えてもらえないだろうか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020039")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:「子供じみてる」と笑われそうだから遠慮しておく
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020040")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ず、ずるいぞ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020041")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いつかそのときが来たら、な
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020043")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ただ、レッスンを通じて女の子らしくあるのもいいと思えてきた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020045")

	change_face(Actor001,"Normal")

	--★★ノワール★★:鎧を着るのをやめるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020046")

-- ▼直接出力
 --フィエナ登場のためにカメラを指定
CloseTalkWindow()
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:それは…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020047")

-- ▼直接出力
 --フィエナ登場
CloseTalkWindow()
Appear(Actor003)
wait_time(0.2)
setup_small_camera_start()
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力

	--★★フィエナ★★:あ、いた、ガラハッド！<br>最近、女の子女の子してるって噂が…わ～！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_08020049")

	change_face(Actor003,"Surprise")

	--★★フィエナ★★:すごーい！これガラハッドが焼いたの？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_08020051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:そ、そうです
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020052")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:きちんとレッスンを活かしているようで感心感心、だよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_08020053")

	change_face(Actor003,"Normal")

	--★★フィエナ★★:ここまでできればもう平気、かな～？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_08020054")


	--★★ガラハッド★★:平気…とは
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_08020055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "照れ")
-- ▲直接出力

	--★★フィエナ★★:ふっふっふ～
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_08020056")

	PlayAction(Actor003,"to  Std_Appl")
	change_face(Actor003,"Smile")

	--★★フィエナ★★:プリンセス・ＬＯＶＥサバイバル最終試験を行いまーす！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_08020057")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もはやプロジェクト名が原型をとどめていないぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…っていうか、最終試験！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_08020059")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor003, false)
set_common_look_at(Actor003,Actor002)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:そういうことだからガラハッド！女子力を磨いてその日を待つように！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_08020060")

-- ▼直接出力
local trustParam = set_communication_rankup("ガラハッド_コミュランク", "ガラハッド_親密度")
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
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
