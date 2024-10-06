-- このluaスクリプトは、CO_101015_0602.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114011_01","114011_01_h")
Include("content_adv_advsmall_114011_01","Template114011_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName114011_01,CameraPos114011_01_002)
	InitializeTemplateRandomCamera114011_01()
	InitializeTemplate114011_01()
-- ▼直接出力
turn_lookat(Actor002,Actor003,0)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)

-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:見えるか？<br>ロンディニウムの復興が進んでいる様子が
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020002")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ひどい事件だったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:………ああ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:笑顔があふれる華やかな街だった<br>住民たちはみなログレスに親しんでくれた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020005")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★アーサー★★:…なんの罪もない彼らを襲うなどとは
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020006")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
wait_time(WAIT_TIME_SHORT)
setup_small_camera_end(Camera002)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("市民_男1", "怒り")
-- ▲直接出力

	--★★市民（男）★★:お前は…アーサー！
	Talk(Actor003,"NPCNAME_0123","speech","N","CO_101015_06020008")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:…ロンディニウムの住民か？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020009")


	--★★市民（男）★★:他人事のように言いやがって！
	Talk(Actor003,"NPCNAME_0123","speech","N","CO_101015_06020010")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("市民_男1", "激怒")
-- ▲直接出力

	--★★市民（男）★★:お前らログレスの連中が<br>住民をたくさん殺したんだろうが！
	Talk(Actor003,"NPCNAME_0123","speech","N","CO_101015_06020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Normal")

	--★★ノワール★★:おい、それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101015_06020012")

	close_cutin()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★アーサー★★:ノワール
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020013")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("市民_男1", "落胆")
-- ▲直接出力

	--★★市民（男）★★:俺たちは俺たちの手で<br>ロンディニウムを復興する
	Talk(Actor003,"NPCNAME_0123","speech","N","CO_101015_06020015")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（男）★★:もう二度と、お前らの好きにはさせない
	Talk(Actor003,"NPCNAME_0123","speech","N","CO_101015_06020016")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:アーサー…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020018")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力

	--★★アーサー★★:こうも憎しみをストレートにぶつけられると<br>なかなかキツいものがあるな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020019")


	--★★アーサー★★:もちろん、承知していたことではあるが
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…なんで、わざわざここに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:この痛みを忘れないために<br>ノワール<br>痛み…？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020022")


	--★★ノワール★★:痛み…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020064")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:今、俺の目の前に広がるすべてが<br>俺が王として至らなかったばかりに起きたこと
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020023")


	--★★アーサー★★:その責任を俺は負わねばならない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020024")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:あんたひとりで抱え込むことじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "否定")
-- ▲直接出力

	--★★アーサー★★:抱え込むのが王の仕事だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:…だが<br>ひとりでは抱えきれなかったかもしれない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:向き合う覚悟ができたのは、お前のおかげだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020030")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺の？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:お前が俺を認めてくれたから
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101015_06020034","CO_101015_06020035","CO_101015_06020036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたを認めてるのは俺だけじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020038")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:円卓の仲間たちや学園の生徒<br>それに街の人たちだって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:みんながあんたを認めて…支えたいと思ってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:…そうだな<br>みんな俺を支えてくれている
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020041")

	change_face(Actor002,"Normal")

	--★★アーサー★★:世界に誇れる<br>俺の宝物たちだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020042")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…認めるよ<br>あんたは立派な王だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020044")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:継承者のお墨付き<br>これはずいぶんと光栄なことだな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020045")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:茶化すなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020046")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:茶化してなどいないさ<br>嬉しいんだよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020047")

	change_face(Actor002,"Sad")

	--★★アーサー★★:だが、まだまだだ<br>俺はまだ王として足りていなかった
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020048")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:すべてを引き受ける覚悟が
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020049")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺は…そんなつもりで言ったんじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020051")

	change_face(Actor001,"Sad")

	--★★ノワール★★:確かに、王としてあんたがしてきたことを<br>みんなが認めてるとは言ったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020052")

	change_face(Actor001,"Sad")

	--★★ノワール★★:だけどそれは、あんたひとりに<br>重荷を背負わせたいからじゃない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020053")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:そうだな<br>俺が都合のいいように解釈した
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020054")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:欲しい言葉をくれたんだ、お前は
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020056")

	goto Block1end

::Block1end::
	change_face(Actor002,"Sad")

	--★★アーサー★★:崩れ去った平穏、突き刺すような敵意<br>…すべてが俺の咎だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020058")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:俺はここにあるすべてを忘れてはならない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020059")


	--★★アーサー★★:俺を信じて<br>ついてきてくれる者たちがいるからこそ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")

	--★★アーサー★★:俺は<br>立派な王にならなければならないんだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020061")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…なら、俺はそんなあんたを支えるよ<br>――円卓の騎士として
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_06020062")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:…心強い
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_06020063")

-- ▼直接出力
local trustParam = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
	load_area_scene_preload(114011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
