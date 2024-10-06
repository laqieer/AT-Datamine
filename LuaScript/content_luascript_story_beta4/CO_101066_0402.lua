-- このluaスクリプトは、CO_101066_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-130,CharaPos110151_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_001)
	Camera002 = SetTemplate("Actor002",35,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	Camera003 = SetTemplate("Actor003",40,CharaPos110151_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_003)
	Camera004 = SetTemplate("Actor004",60,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera005 = SetTemplate("Actor005",145,CharaPos110151_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_005)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
-- ▼直接出力
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{0.9,0,2.2})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.08,0,1.92})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-0.7,0,5.7})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(RndCamera008)
PlayPartVoiceDirect("ブレイズ","0038")
-- ▲直接出力

	--★★ブレイズ★★:よしよし、それじゃ早速研究を…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020002")

-- ▼直接出力
PlayPartVoiceDirect("女子1","0002")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）A★★:あっ、ブレイズせんせ～！
	Talk(Actor006,"NPCNAME_0146","speech","N","CO_101066_04020003")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-80,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力

	--★★ブレイズ★★:おうおう、どうしたんじゃ～<br>授業の質問か？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020005")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,0.5, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Appear(Actor003)
Appear(Actor004)
setup_small_camera_start(RndCamera005)
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("女子1","0010")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:え～？質問とかないけど～<br>せんせーとお話したいから来たんだよ～
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101066_04020006")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Yes")
PlayActionDirect(Actor004,"to  Std_Yes")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）たち★★:ね～！
	Talk(Actor007,"NPCNAME_0273","speech","N","CO_101066_04020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:そうかそうか～！ワシの魅力に気づくとは<br>おぬしら、若いのになかなかやるのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020008")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("女子2","0011")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:だって先生、ちょーかわいいんだもん<br>特に髭がキュートでイケてる～
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101066_04020009")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:ウソ！ワシ、カワイイ？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020010")

-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Joy")
PlayActionDirect(Actor003,"to  Std_Joy")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）たち★★:かわいい～！
	Talk(Actor007,"NPCNAME_0273","speech","N","CO_101066_04020011")

-- ▼直接出力
setup_small_camera_end(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ふぉっふぉっふぉ<br>こりゃ、照れちゃうのう～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020012")


	--★★ノワール★★:（すごくデレデレしている…！）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_04020013")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0045")
-- ▲直接出力

	--★★ブレイズ★★:若い子にはかなわんのう。けどもな<br>ワシはカワイイだけじゃないんじゃぞ？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020014")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:昔は山より大きなドラゴンを倒したこともある<br>スゴウデの魔法使いなんじゃから～！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020015")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("女子1","0028")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:え～、マジで～？<br>山より大きいドラゴンを～？
	Talk(Actor003,"NPCNAME_0146","speech","N","CO_101066_04020016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:マジマジ、これマジなんじゃよ！<br>しかもひとりで！！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020017")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("女子2","0045")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:しんじらんなーい！
	Talk(Actor004,"NPCNAME_0147","speech","N","CO_101066_04020018")


	--★★ノワール★★:（俺も…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_04020019")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0011")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:なんと～！それじゃかわいいおぬしたちに<br>在りし日のワシの雄姿、語っちゃおうかのう～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020020")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor005)
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005, -0.646, 0, 3.817, 1.5)
wait_time(1.5)
PlayActionDirect(Actor005,"to Std_Loop")
setup_small_camera_start(Camera005)
wait_time(0.7)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0006")
-- ▲直接出力

	--★★マーリン★★:先生、アーサー様がお呼びです
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020022")

-- ▼直接出力
wait_time(0.5)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★マーリン★★:先生…？
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020024")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…おしゃべりに夢中で聞いてないみたいですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020025")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
SkipDefaultMotion(Actor002)
wait_time(0.2)
PlayActionDirect(Actor004,"to  Std_Joy")
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Yes")
SkipDefaultMotion(Actor002)
wait_time(0.4)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005, 0.19, 0, 2.67, 1)
wait_time(0.7)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Yes")
PlayActionDirect(Actor005,"to  Std_Angry")
-- ▲直接出力
	open_cutin(2,2)
	on_cutin(1,Actor005,"Anger")
	on_cutin(2,Actor002,"Surprise")

	--★★マーリン★★:はぁ…仕方ありませんね<br>………えいっ
	Talk(Actor005,"CHRNAME_MERLIN","speech","N","CO_101066_04020026")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
PlayActionDirect(Actor002,"to  Std_Talk")
SkipDefaultMotion(Actor002)
-- ▲直接出力

	--★★ブレイズ★★:もがっ！？
	Talk(Actor002,"CHRNAME_BLAZE","speech","N","CO_101066_04020027")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	close_cutin()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ちょっ、え！？ブレイズ先生！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020029")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★ブレイズ★★:………
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020030")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ノワール★★:ブレイズ先生が固まった…！<br>マーリンさん、いったいこれは…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020031")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マーリン★★:特注のチョコレートファッジです
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020032")

-- ▼直接出力
PlayPartVoiceDirect("マーリン","0010")
-- ▲直接出力

	--★★マーリン★★:うちの先生は甘いものを食べると<br>思考停止してこうなるのです
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020033")

-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,215,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.4)
-- ▲直接出力

	--★★マーリン★★:さあ、あなたたちはそろそろお戻りなさい
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020034")

-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Yes")
PlayActionDirect(Actor003,"to  Std_Yes")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）たち★★:は～い
	Talk(Actor007,"NPCNAME_0273","speech","N","CO_101066_04020035")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor003)
Hide(Actor004)
set_pos(Actor005,{-0.3, 0, 2})
turn_chara(Actor005,60,0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
wait_time(0.2)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力

	--★★ブレイズ★★:………はっ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020037")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0011_1")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、目を覚ましましたよマーリンさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020038")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力

	--★★マーリン★★:ええ。完全に食べ切ったようですね
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020039")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ブレイズ★★:ワシはいったい…！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020040")

	open_select_window_tag(Actor001,"Normal","CO_101066_04020042","CO_101066_04020043")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020045")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoiceDirect("ブレイズ","0029")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:大丈夫なわけあるかい！<br>口の中が甘ったるくてたまらんわ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:早いところ塩分を補強せねば、<br>ワシの偉大な頭脳がしなびてしまうぞ～！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それだけ口が回れば大丈夫だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020048")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もうひとついっとく？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020050")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0030")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:勘弁してくれ～<br>ワシ、甘い食べ物だけは駄目なんじゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020051")

	change_face(Actor002,"Sad")

	--★★ブレイズ★★:頭がトロ～ンとするというかなんというか<br>あんなもの食べるやつの気が知れんわい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020052")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あんたにだけは言われたくないんだが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020053")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101066_sp_0002_2")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:マーリン！お主はまた師匠の口に<br>スイーツなんぞを突っ込んでからに～！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020055")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0010")
-- ▲直接出力

	--★★マーリン★★:先生が私の呼びかけをお聞きにならないからです<br>そんなことより、アーサー様がお呼びですよ
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020056")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:なに？アーサー王が？<br>バルバロイ研究の進捗の件かのう。それとも…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020057")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0013")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:それともまた、若かりしマーリンの話が<br>聞きたいと仰るのかのう～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020059")

-- ▼直接出力
PlayPartVoiceDirect("マーリン","0029")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor005,"Surprise")

	--★★マーリン★★:は！？！？
	Talk(Actor005,"CHRNAME_MERLIN","speech","N","CO_101066_04020060")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	close_cutin()
	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
turn_chara(Actor001,-130,0)
-- ▲直接出力

	--★★マーリン★★:なっ！は！？え！？なななな、なにを！？<br>なにを言ってるんですか、先生！？
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020061")

	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0031")
-- ▲直接出力

	--★★マーリン★★:アーサー様になにを教えたの？<br>ねえ、先生！？
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020062")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-150,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
PlayPartVoiceDirect("ブレイズ","0010")
PlayActionDirect(Actor002,"to Wlk")
slidemove(Actor002, -2.6, 0, -5.3, 4)
-- ▲直接出力

	--★★ブレイズ★★:ふぉっふぉっふぉ！まったくアーサー王ったら<br>マーリンに目がないんじゃから～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_04020063")

-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,215,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to  Std_Angry")
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マーリン★★:ちょ、ちょっと先生！？待ってください！<br>待って…待ってって言ってるじゃない！
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020065")

	PlayAction(Actor005,"to  Std_No")
	change_face(Actor005,"Shy")

	--★★マーリン★★:もう！変なこと言い残していかないでってば――
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020066")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ま、マーリンさん…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020068")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★マーリン★★:はっ！
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020069")

-- ▼直接出力
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,35,0.4)
wait_time(0.4)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マーリン★★:…なんでもありません<br>忘れてください、ノワール様
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020070")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どれをですか？<br>アーサーがマーリンさんのことを
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020071")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0011")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★マーリン★★:ノワール様？
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020073")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:すみません
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020074")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★マーリン★★:…あれは先生の冗談です<br>真に受けないでください
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020075")

-- ▼直接出力
wait_time(0.3)
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…なるほど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101009_sp_0011_1")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あの…あの人、本当にあなたの師匠なんですか<br>なんか胡散臭いっていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020077")


	--★★ノワール★★:山よりも大きなドラゴンを倒したとか<br>大げさな話ばかりでどこまで本当か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020078")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0007")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マーリン★★:先生の武勇伝はすべて本当のことです
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020079")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そう…なんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020080")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力

	--★★マーリン★★:ええ。疑われてもしかたないですけれど…<br>ですが先生は本当にすごい方なんですよ
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020081")


	--★★マーリン★★:あの方は若くして魔法の神髄を知り<br>人の身で扱える最高峰の魔法を会得した方
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020082")


	--★★マーリン★★:魔法の腕前で先生にかなう者は<br>今、恐らくこの世界にはいないと思います
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020083")

	PlayAction(Actor005,"to  Std_Talk")

	--★★マーリン★★:魔術の教本にも<br>先生の名前は何度も出てきますよ
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020084")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:そうなんですか<br>ちょっと信じがたいですけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_04020085")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0038")
-- ▲直接出力

	--★★マーリン★★:ノワール様もいずれ<br>その力を目にすることがあるでしょう
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020086")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:そのときをお待ちください
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","CO_101066_04020087")

-- ▼直接出力
local trustParam = set_communication_rankup("ブレイズ_コミュランク", "ブレイズ_親密度")
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
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
