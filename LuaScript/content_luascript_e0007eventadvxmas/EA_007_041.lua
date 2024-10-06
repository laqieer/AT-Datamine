-- このluaスクリプトは、EA_007_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.45,0.1,0.8,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
PlayActionDirect(Actor002,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-1.04,0,-1.84})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{-1.526,0,-2.297})
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({1.523, 1.947, -5.365,   12, 285, 0,   25})
-- ▲直接出力
-- ▼直接出力
lookobj = create_object("kara")
set_pos_object(lookobj,-0.95,1.5,-5.42)
-- ▲直接出力
-- ▼直接出力
CameraEx_02 = set_camera({0.07, 1.664, -4.918,   12, 267.6556, 0,   25})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101023","001","101023001")
	Actor006 = InitializeCharacter_2DOnly("101009","002","101009002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.3)
PlayActionDirect(Actor001,"to  Std_Talk")
wait_time(1.2)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0002")
-- ▲直接出力

	--★★カイル★★:ボクひとりでも平気だから！！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410004")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リアム","0017")
-- ▲直接出力

	--★★リアム★★:行かせません
	Talk(Actor001,"CHRNAME_LIAM","speech","L","EA_007_0410005")

-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0015")
-- ▲直接出力

	--★★カイル★★:わからずや！！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リアム","0007")
-- ▲直接出力

	--★★リアム★★:
	Talk(Actor001,"CHRNAME_LIAM","speech","L","EA_007_0410007")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
on_active(Actor003)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,CharaPos110101_01_007[1],CharaPos110101_01_007[2],CharaPos110101_01_007[3],0)
slidemove(Actor003,CharaPos110101_01_007[1],CharaPos110101_01_007[2],CharaPos110101_01_007[3],2.0)
wait_time(1.7)
setup_small_camera_start(Camera003)
wait_time(0.3)
turn_chara(Actor003,158,0.1)
wait_time(0.1)
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor002,340,0)
turn_chara(Actor001,5.5,0)
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.40,0.1,0.7,0.2)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0004")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:どうしたんだ…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★カイル★★:どうもしてない！！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410010")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
change_face(Actor003,"Normal")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★リアム★★:あの、ノワールさん…礼拝の前に<br>少し手伝っていただけないでしょうか
	Talk(Actor001,"CHRNAME_LIAM","speech","L","EA_007_0410011")

-- ▼直接出力
PlayPartVoiceDirect("リアム","0008")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★リアム★★:カイルくんが<br>街の外に出たがっておりまして──
	Talk(Actor001,"CHRNAME_LIAM","speech","L","EA_007_0410012")

	PlayAction(Actor002,"to  Std_Talk")

	--★★カイル★★:プレゼント探しに行くだけだよ！！<br>すぐ帰ってくるし！！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:プレゼント──…って<br>もしかしてあの、白い花のことか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0007")
-- ▲直接出力

	--★★カイル★★:マルイルさんに聞いたんだ<br>『天使の贈り物』の咲いてる場所！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410015")


	--★★カイル★★:この時期にしか咲かないんだってさ<br>だから行かないと、なくなっちゃうだろ！？
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410016")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410017")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ノワール★★:今………ローマ軍は空中分解して<br>その残党が各地に散っている
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410018")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力

	--★★ノワール★★:さらに魔女の影響もあって<br>ブリテン全域でバルバロイが活性化している
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410029")

	PlayAction(Actor002,"to  Std_Talk")

	--★★カイル★★:でも、でもさあ──
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410030")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0017")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★クラリス2★★:いけませんよ。駄々は
	Talk(Actor005,"CHRNAME_CLARICE","speech","L","EA_007_0410032")

-- ▼直接出力
CloseTalkWindow()
on_active(Actor004)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat_position(Actor004,CharaPos110101_01_006[1],CharaPos110101_01_006[2],CharaPos110101_01_006[3],0)
slidemove(Actor004,CharaPos110101_01_006[1],CharaPos110101_01_006[2],CharaPos110101_01_006[3],2.0)
wait_time(2.0)
lookat_delay_weight(Actor003,0.45,0.1,0.8,0.2,1.0)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1.0)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
turn_chara(Actor004,110,0.4)
wait_time(0.4)
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力

	--★★カイル★★:…なんだよ<br>クラリスお姉ちゃんまで
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410034")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:カイルくんがひとりで出て行って<br>なにかあったら、ご両親が悲しみます
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★カイル★★:悲しまないよ
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410036")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410037")


	--★★カイル★★:仕事が楽しいんだよ<br>ママもパパも
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0021")
-- ▲直接出力

	--★★カイル★★:ボクなんかどうでもいいんだ
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410039")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:だからプレゼントで<br>驚かせてやりたい………？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410040")


	--★★カイル★★:………だめかな
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0017")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★クラリス★★:メッ、ですね
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410042")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0015")
-- ▲直接出力

	--★★カイル★★:なんだよ！！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410043")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0023")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:カイルくんが傷ついたら<br>わたしも悲しい
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410044")


	--★★カイル2★★:………
	Talk(Actor006,"NPCNAME_0386","speech","N","EA_007_0410045")

-- ▼直接出力
PlayPartVoiceDirect("クラリス","0015")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:それと………怖がらせたくはないのですが
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410046")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★クラリス★★:カイルくん<br>あなたに…不幸が視えます
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0028")
-- ▲直接出力

	--★★カイル★★:…ふ、ふ、不幸？
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410048")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0025")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:一歩間違えば<br>ログレス全体を巻き込むような不幸が
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410049")


	--★★カイル★★:それって、どんな──
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410050")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:…どんなでしょう～？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0015")
-- ▲直接出力

	--★★カイル★★:なんだよそれ！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410052")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0034")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★クラリス★★:やはり…ぼんやりとしか視えず
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410053")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リアム","0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★リアム★★:では万全を期して<br>カイルくんを守るしかありませんね…
	Talk(Actor001,"CHRNAME_LIAM","speech","L","EA_007_0410054")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0040")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:…ですが、なにもしないでいれば<br>なにが不幸かもわからないままです
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410055")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★クラリス★★:なにもしないことで不幸が起こる<br>という可能性もありえます
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410056")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("リアム","0034")
-- ▲直接出力

	--★★リアム★★:では…どうすれば──
	Talk(Actor001,"CHRNAME_LIAM","speech","L","EA_007_0410057")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:ですので<br>いっしょに出かけましょう～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410058")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0028")
-- ▲直接出力

	--★★カイル★★:！？<br>いいの！？
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★クラリス★★:いっしょになら、です<br>また危ない人が近づいてきても困りますし
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410061")


	--★★クラリス★★:それと、条件付きですよ
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410062")

	PlayAction(Actor004,"to  Std_Talk")

	--★★クラリス★★:白い花を手に入れたら<br>それ以降の外出は禁止です。どうでしょうか？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410063")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0007")
-- ▲直接出力

	--★★カイル★★:わかった！！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410064")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_007_0410066","EA_007_0410067")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
wait_time(0.25)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:やっぱり危険だ、クラリス
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410070")

-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0015")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★カイル★★:水差さないでよ！<br>ノワールお兄ちゃん！
	Talk(Actor002,"NPCNAME_0386","speech","N","EA_007_0410071")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:そうですよ～ノワールくん<br>サプライズにリスクはつきものです～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410072")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",1.0)
wait_time(0.25)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:…乗ったよ。クラリス
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410075")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0011")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:そう言ってくれると思ってました～<br>ふふ。では護衛をお願いします～
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410076")

	change_face(Actor003,"Surprise")

	--★★ノワール★★:………あれ、俺の返答も想定済だったのか…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410077")

	goto Block1end

::Block1end::
-- ▼直接出力
lookat_delay_weight(Actor004,0.45,0.1,0.7,0.2,1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0015")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410080")

	change_face(Actor004,"Laugh")

	--★★クラリス★★:『天使の贈り物』の群生地近くを<br>通る進軍ルートです。それに便乗しましょう
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410082")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:ログレスの危機が予見されている以上<br>ケイ様も了承してくださいました
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410083")

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
slidemove(CameraEx_01,{1.356,1.91,-5.32},10)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★クラリス★★:どこも人手不足のようですしね
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410084")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0007")
-- ▲直接出力

	--★★クラリス★★:兵士さんたちが拓いた道を通って<br>群生地まで向かいます
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410085")


	--★★クラリス★★:道中、野性の魔物が出現する恐れはありますが<br>そこはわたしたちで対処します
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410086")

	change_face(Actor003,"Surprise")

	--★★ノワール★★:………クラリス
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_007_0410087")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat_object(Actor004,nil,"kara",0.7)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0010")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★クラリス★★:わからないものですね～<br>なにが幸福で、どうすれば不幸を止められるのか
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410089")

	change_face(Actor004,"Normal")

	--★★クラリス★★:だから…それがわかるまでは
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410090")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CameraEx_02)
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",0.8)
wait_time(0.6)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クラリス","0011")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★クラリス★★:ふらふらしてみるのも<br>いいですよね？
	Talk(Actor004,"CHRNAME_CLARICE","speech","L","EA_007_0410092")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101023","001","101023001")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
