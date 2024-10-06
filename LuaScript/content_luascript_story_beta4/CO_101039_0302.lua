-- このluaスクリプトは、CO_101039_0302.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110091_01","110091_01_h")
Include("content_adv_advsmall_110091_01","Template110091_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110091_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110091_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110091_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110091_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_007)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110091_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_002)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110091_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_001)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110091_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_501_01_StdController","to Std_Loop",CameraAssetBundleName110091_01,CameraPos110091_01_008)
	InitializeTemplateRandomCamera110091_01()
	InitializeTemplate110091_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.45,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
lookat_weight(Actor003,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
keep_ik_lookat(Actor006,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
keep_ik_lookat(Actor007,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor008, false)
keep_ik_lookat(Actor008,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110091)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:準備運動はしっかりやろうね<br>ノワールくん
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:そうだな<br>ケガしないようにしないと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020003")

-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ローラ★★:ノワールさん、ありがとう<br>お姉ちゃんのワガママに付き合ってくれて
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_03020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:いやいや<br>俺もちょうど体を動かしたいなと思ってたから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020005")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:今日は頑張ろうね～<br>ローラも応援よろしくっ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020006")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
wait_time(0.3)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力

	--★★ローラ★★:うん！
	Talk(Actor003,"CHRNAME_LOLA","speech","L","CO_101039_03020007")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
setup_small_camera_start(RndCamera005)
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ローラって運動苦手なのかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★フレン★★:そんなことないよ！<br>運動神経バツグンだよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020010")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:だったら<br>一緒に運動すればいいのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020011")


	--★★フレン★★:何度も誘ってるんだけどね<br>応援でいいんだって
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そっか。まあ無理強いはできないしな<br>…って、ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020013")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor005,Camera005,EntryData110091_01_07,CameraAssetBundleName110091_01,CameraPos110091_01_107)
-- ▲直接出力
-- ▼直接出力
 --注視調整
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",1.0)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",1.0)
keep_delay_ik_lookat(Actor006,Actor005,"J_Head",1.0)
keep_delay_ik_lookat(Actor007,Actor005,"J_Head",1.0)
keep_delay_ik_lookat(Actor008,Actor005,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
 --キャラの向き変更
turn_chara(Actor001,200,0)
turn_chara(Actor002,153,0)
PlayActionDirect(Actor008,"to Wlk")
turn_chara(Actor008,235,0.3)
wait_time(0.3)
PlayActionDirect(Actor008,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:なにかご用ですか？
	Talk(Actor006,"NPCNAME_0151","speech","N","CO_101039_03020015")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:邪魔だ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","CO_101039_03020016")

-- ▼直接出力
PlayPartVoice("男子2", "驚き")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:えっ？
	Talk(Actor006,"NPCNAME_0151","speech","N","CO_101039_03020017")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ルーシャス★★:余の進む道をふさぐな<br>身の程をわきまえよ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","CO_101039_03020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:ちょっとちょっと！ルーシャスくん！<br>その言いかたはないんじゃない？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020020")


	--★★フレン★★:自分が避ければいいだけでしょ？<br>それなのに「邪魔だ」なんて
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020021")

-- ▼直接出力
PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力

	--★★ルーシャス★★:無礼者に道理を教えてやったまでのこと<br>感謝されてもいいくらいと思うがな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","CO_101039_03020022")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "激怒")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:なんだよ偉そうに！<br>自分を何様と思ってるんだ！
	Talk(Actor006,"NPCNAME_0151","speech","N","CO_101039_03020023")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ルーシャス★★:ローマ皇太子だが？
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","CO_101039_03020024")


	--★★ルーシャス★★:余はそなたらのように<br>自堕落に時間を過ごすことは許されておらぬ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","CO_101039_03020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera005)
end
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス", "否定")
-- ▲直接出力

	--★★ルーシャス★★:さっさとそこをどけ
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","CO_101039_03020027")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor005)
setup_small_camera_start()
turn_chara(Actor001,255,0)
turn_chara(Actor002,135,0)
turn_chara(Actor008,265,0)
 --注視調整
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor006,"J_Head")
keep_ik_lookat(Actor006,Actor002,"J_Head")
keep_ik_lookat(Actor007,Actor002,"J_Head")
keep_ik_lookat(Actor008,Actor002,"J_Head")
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("女子1", "怒り")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）★★:なにあれ
	Talk(Actor007,"NPCNAME_0146","speech","N","CO_101039_03020029")

-- ▼直接出力
PlayPartVoice("女子2", "落胆")
-- ▲直接出力

	--★★キャメロット騎士学術院（女）②★★:こんなに広い場所なのに<br>避けろって…
	Talk(Actor008,"NPCNAME_0147","speech","N","CO_101039_03020030")

-- ▼直接出力
PlayPartVoice("男子2", "怒り")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:ローマがどれだけ偉いんだよ
	Talk(Actor006,"NPCNAME_0151","speech","N","CO_101039_03020031")


	--★★フレン★★:ルーシャスくん、感じ悪い！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）★★:ありがとう、フレン<br>俺なら気にしてないから
	Talk(Actor006,"NPCNAME_0151","speech","N","CO_101039_03020034")

	change_face(Actor002,"Sad")

	--★★フレン★★:…ローマのこと、嫌いにならないでね？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020035")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子2", "笑い")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:あはは、なるわけないじゃん
	Talk(Actor006,"NPCNAME_0151","speech","N","CO_101039_03020036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ありがとう！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ルーシャスにも困ったもんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020038")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.2)
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",1.0)
wait_time(0.1)
keep_delay_ik_lookat(Actor007,Actor001,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:ほんとだよ<br>皇太子である前に同じ学園の生徒なのにね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020039")

-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:みんなに嫌われたら<br>楽しく学園生活を送れなくなっちゃうよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:…あっ！？ルーシャスくんを陸上部に混ぜて<br>一緒に運動して仲良くなればいいのかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020041")

	open_select_window_tag(Actor001,"Normal","CO_101039_03020043","CO_101039_03020044")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:来るかどうかはさておき<br>あいつが参加したら面白そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020046")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:でしょでしょ～？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020047")

	change_face(Actor002,"Surprise")

	--★★フレン★★:でもルーシャスくん<br>運動系の授業は出てないんだよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020048")

	change_face(Actor002,"Normal")

	--★★フレン★★:「汗をかくなど下々の者のすることだ<br>皇太子はいつも涼やかにあらねばならん」って
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020049")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんだそれ？<br>あいつの理屈はわかんないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:だよね？あはは！<br>でも、誘うだけ誘ってみようかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020051")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:無理じゃないか～？<br>だってルーシャスだぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020053")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:「そなたらが余と競い合うだと？<br>なにかひとつでも勝てると思っているのか」
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020054")

	change_face(Actor001,"Smile")

	--★★ノワール★★:…とか言うぞ、きっと
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:あはは、似てる！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020056")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:でも<br>きっとそうなっちゃうよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020057")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★フレン★★:ルーシャスくんって<br>ひとりでいることが多いよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020059")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:普段から偉そうなこと言っているだけあって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020060")


	--★★ノワール★★:あいつはひとりでなんでもできちゃうから<br>群れる必要なんてないんだろうけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:皇太子として不用意に人と交わることを<br>許されていないのかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020062")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:…なんて考えることもある<br>あくまでも俺の想像だけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020063")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:もし本当にそうなんだとしたら
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020064")


	--★★フレン★★:なんだかさみしいね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020066")

	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
PlayPartVoice("男子1", "挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:おーい、フレンにノワール！<br>そろそろ対抗戦をはじめるぞー！
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_03020067")

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:あ、ごめん！<br>行こう、ノワールくん
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020068")

-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
setup_small_camera_end()
Appear(Actor004)
Hide(Actor006)
Hide(Actor007)
Hide(Actor008)
turn_lookat(Actor001,Actor004,0)
turn_lookat(Actor002,Actor004,0)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ねえ、ジーン部長
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020070")

	PlayAction(Actor002,"to  Std_Talk")

	--★★フレン★★:陸上部の部員も増えてきたしさ<br>競技大会みたいなの、やりたいと思わない？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020071")


	--★★フレン★★:練習よりも盛り上がるだろうし<br>それを見て入部希望者も増えると思うんだよね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020072")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("男子1", "悩む")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:ふーむ、大会か
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_03020073")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★キャメロット騎士学術院（男）③★★:あまり大がかりなものは<br>準備できないだろうけど…うん、面白そうだ
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_03020075")

-- ▼直接出力
PlayPartVoice("男子1", "肯定")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）③★★:今度、先生方にかけ合ってみよう
	Talk(Actor004,"NPCNAME_0241","speech","N","CO_101039_03020076")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.9)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力

	--★★フレン★★:当然<br>ノワールくんも参加してくれるよね？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020077")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺も！？<br>まあ、余裕があるときならいいけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_03020078")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フレン", "喜び")
-- ▲直接出力

	--★★フレン★★:よーし！大会に向けて<br>準備に練習、頑張るぞーっ！！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_03020079")

-- ▼直接出力
local trustParam = set_communication_rankup("フレン_コミュランク", "フレン_親密度")
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
	load_area_scene_preload(110091)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110091_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
