-- このluaスクリプトは、CO_101028_1003.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111016_02","111016_02_h")
Include("content_adv_advsmall_111016_02","Template111016_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",100,CharaPos111016_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111016_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111016_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName111016_02,CameraPos111016_02_002)
	InitializeTemplateRandomCamera111016_02()
	InitializeTemplate111016_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111016)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:フィエナはガラハッドのこと拒絶したりしていなかっただろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10030002")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:ガラハッドが早計だった。恥ずかしいかぎりだノワールにも面倒をかけたな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030003")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ただ、強い騎士を目指す気持ちは変わらない今はまだ鎧を脱ぐことはできない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それでこそだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10030005")


	--★★ガラハッド★★:でも、たまになら学園以外でスカートを履く日を作ってもいいかもしれない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030007")

-- ▼直接出力
PlayPartVoice("ガラハッド", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そう思えたのもノワールのおかげだレッスンに付き合ってくれてありがとう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101028_10030010","CO_101028_10030011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:どういたしましてフリフリのドレス、楽しみしてるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10030013")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:う、そ、それは…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030015")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:もっと…修行を積んでから、な
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:こちらこそ、どういたしまして俺もデート、楽しかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10030018")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:ノワールも、楽しんでくれたのか
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030019")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:あれが、僕の初めてのデートだったから…嬉しい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030021")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:手伝いが必要になったらいつでも言ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10030023")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:騎士としてレディをエスコートさせてもらうよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10030024")

	change_face(Actor002,"Shy")

	--★★ガラハッド★★:よ、よろしく頼む…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:あっ！ち、違うぞ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030027")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ガラハッド★★:女の子らしく振る舞うと姉上が喜んでくれるからそれが僕にとっては嬉しいわけで
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030029")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:決してノワールからの誘いが嬉しいわけではないだって僕は騎士なのだから！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030030")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:いや、でも、誘いが嬉しくないわけでもないから…あああ、もう！なんと答えたらいいんだ！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030031")

-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:女の子の気持ちで答えればいいんじゃない？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_10030033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:騎士として答えるのが正解だと思うな、俺は
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_10030035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "苦しみ")
-- ▲直接出力

	--★★ガラハッド★★:うう…意地悪…！！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_10030036")

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
	load_area_scene_preload(111016)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111016_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
