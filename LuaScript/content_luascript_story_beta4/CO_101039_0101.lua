-- このluaスクリプトは、CO_101039_0101.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110091_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_008)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_001)
	Camera005 = SetTemplate("Actor005",150,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110091_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	Actor010 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_delay_weight(Actor001,0.5,0.2,0.8,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor006,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor002,"J_Head")
lookat_delay_weight(Actor003,0.5,0.2,0.8,0.2,1.0)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
keep_ik_lookat(Actor004,Actor002,"J_Head")
lookat_weight(Actor004,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
keep_ik_lookat(Actor005,Actor002,"J_Head")
lookat_weight(Actor005,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
keep_ik_lookat(Actor006,Actor002,"J_Head")
lookat_weight(Actor006,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
keep_ik_lookat(Actor007,Actor002,"J_Head")
lookat_weight(Actor007,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor002,"J_Head")
lookat_weight(Actor008,0.4,0.1,0.8,0.2)
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	PlayAction(Actor006,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("男子2", "悲しみ")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:はぁ、はぁ…フレンは早いなあ<br>短距離走じゃまったくかなわないよ
	Talk(Actor006,"NPCNAME_0151","speech","N","CO_101039_01010002")

-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ふっふっふー<br>長距離走でも負ける気はないけどね！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:ふうん<br>みんなで集まって運動してるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("現代男子", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:フレン、少し休んだら<br>次は俺と勝負してくれよ！
	Talk(Actor005,"NPCNAME_0153","speech","N","CO_101039_01010005")

	change_face(Actor002,"Surprise")

	--★★フレン★★:今すぐでもいいよ！<br>…あっ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010006")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.6)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:やっほーっ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010008")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ、フレン？<br>なんで俺に…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010009")

	PlayAction(Actor002,"to Greet_one")

	--★★フレン★★:次も勝つから、応援よろしくー！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010010")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:い、いやあ、そんな…困るな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010012")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:頑張れー、お姉ちゃん
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_01010013")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだ<br>ローラに向かって言ってたのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010015")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:えっ？
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_01010016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:あ、いや、こっちのこと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010018")

	change_face(Actor001,"Normal")

	--★★ノワール★★:これはなんの集まりなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010020")

-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:陸上部の活動だよ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_01010021")


	--★★ローラ★★:陸上競技が好きな生徒たちで集まって<br>みんなで競い、高め合ってるの
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_01010022")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ～！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010023")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力

	--★★フレン★★:ローラも走ろうよ！<br>ノワールくんも一緒にどう？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010025")

-- ▼直接出力
keep_delay_ik_lookat(Actor007,Actor001,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor008,Actor001,"J_Head",1.0)
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("女子1", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:一緒に走ろう！
	Talk(Actor007,"NPCNAME_0146","speech","N","CO_101039_01010027")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ふたりが得意な競技は！？
	Talk(Actor006,"NPCNAME_0151","speech","N","CO_101039_01010028")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("現代男子", "肯定2")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）②★★:ノワールとは一度<br>運動で勝負してみたかったんだ！
	Talk(Actor005,"NPCNAME_0153","speech","N","CO_101039_01010029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:ほら、みんなも歓迎してくれてるよ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010030")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★ローラ★★:わ、私はいいよ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_01010031")

	change_face(Actor003,"Smile")

	--★★ローラ★★:お姉ちゃんが楽しそうなところを<br>見ていられれば、それで十分
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_01010032")

	change_face(Actor002,"Surprise")

	--★★フレン★★:え～？<br>たまにはやってみればいいのに～
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010033")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★フレン★★:じゃあさじゃあさ<br>ノワールくんは？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_01010036","CO_101039_01010037")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺もそんな気分じゃないなあ<br>遠慮しとくよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010039")

	change_face(Actor002,"Surprise")

	--★★フレン★★:そんなこと言わずに！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010040")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ごめんな<br>また今度誘ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010041")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:むーっ！<br>こうなったら実力行使だ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010042")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:人数は足りてるみたいだし<br>別に俺たちまで混ざらなくても大丈夫だろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010044")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★フレン★★:それはそうだけどさ～<br>１人でも多いほうが楽しいでしょ♪
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010045")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、フレンの言いたいことが<br>わからないでもないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010046")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:でしょでしょ？<br>ほら、一緒にやろうよ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010047")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わかった、わかったよ<br>仕方ないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010049")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ということで、ノワールくん確保ぉっ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010051")


	--★★生徒たち★★:おおーっ！！
	Talk(Actor009,"NPCNAME_0116","speech","N","CO_101039_01010052")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そんなに盛り上がられても<br>期待に応えられるかはわかんないぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力

	--★★ローラ★★:頑張ってね<br>お姉ちゃん、ノワールさん
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_01010054")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:や、やっぱり<br>俺も応援だけにしとこうかな…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010055")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:ノワールくん、君には光るものを感じる！<br>私と一緒に学園ナンバーワンを目指そう！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010057")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:待て待て待て待て！<br>趣旨が変わってきてるぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010058")

	open_cutin(2,1)
	on_cutin(1,Actor002,"Smile")
	on_cutin(2,Actor003,"Smile")

	--★★フレン/ローラ★★:あははは！
	Talk(Actor010,"CHRNAME_FREN_LOLA","speech","N","CO_101039_01010059")

	close_cutin()
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力

	--★★フレン★★:よ～し！息抜きはこの程度にして<br>みんな、張り切っていこ～っ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010060")


	--★★生徒たち★★:おーっ！
	Talk(Actor009,"NPCNAME_0116","speech","N","CO_101039_01010061")

-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
SkipOffsetCamera(Camera001)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:つ、疲れた…<br>戦闘以外でこんなに動いたの、久しぶりだ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ローラ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ローラ★★:ノワールさん、大丈夫？<br>お水どうぞ
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_01010064")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010065")

-- ▼直接出力
wait_time(0.3)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:私の見込んだとおり！<br>ノワールくんは運動神経バツグンだね！！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010066")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:なあ、ノワール<br>お前も陸上部に入らないか？
	Talk(Actor004,"NPCNAME_0154","speech","N","CO_101039_01010067")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うーん…こうやってみんなと運動するのも<br>悪くないかなって思うけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010068")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:定期的に顔を出すのは<br>ちょっと難しいな…だから、ごめん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010069")

	PlayAction(Actor004,"to  Std_Talk")

	--★★キャメロット騎士学術院（男）③★★:そんなこと言わずにさあ<br>せっかくの才能がもったいない！
	Talk(Actor004,"NPCNAME_0154","speech","N","CO_101039_01010070")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:まあまあ、ジーン部長
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010071")

-- ▼直接出力
--キャメロット騎士学術院（男）③,NPCNAME_0241 @名前変更
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:うーむ…
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_01010072")

-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:ねえ、ノワールくん。定期的には難しくても<br>たまになら来られるよね？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010073")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それなら、まあ、うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010074")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:じゃ、時間があるときに顔出してよ<br>みんなで一緒にいい汗かこうーっ！！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_01010075")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:わかったよ<br>フレンにはかなわないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_01010077")

-- ▼直接出力
local trustParam = set_communication_acquired("フレン_コミュランク", "フレン_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
