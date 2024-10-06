-- このluaスクリプトは、EA_069_031.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera003 = SetTemplate("Actor003",95,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor002)
Hide(Actor003)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Antagonism")
load_sound("BGM_Battle_General1_Intro")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("201010880", "content_still_20101088_image", "201010880_StillImage")
-- ▲直接出力
-- ▼直接出力
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor002,{-6.6,0.0,0.93})
set_pos(Actor003,{-6.036,0.0,1.73})
set_pos(Actor006,{-3.04,0.0,-1.26})
set_pos(Actor007,{-3.37,0.0,-3.82})
turn_chara(Actor006,85,0)
turn_chara(Actor007,62,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101050011)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","005","101020005","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101016","004","101016004","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201017","001","201017001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:無事別荘に棲みついていた獣を追い払った一行は<br>さっそく夏休みを満喫するべく動き出す
	Talk(Actor009,"","narration","N","EA_069_0310002")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力

	--★★アーサー★★:よし。バーベキューの準備はこんなところか<br>あとは水遊びにキャンプファイヤーの用意…
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310003")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:その他もろもろしっかり確認しなくてはな！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0009")
-- ▲直接出力

	--★★ギネヴィア★★:王様自らそんなことするのね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310005")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0007")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:夏休みを全力で楽しむためには<br>まず自分から動かなくてはな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310006")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:王であろうと、ただ待っているだけじゃ<br>欲しいものは手に入らない
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310007")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力

	--★★アーサー★★:ところで、ギネマウアとマーリンはどうした？<br>姿が見えないようだが
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310009")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0034")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:あ…えっと、ふたりは――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310010")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.3)
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101016_sp_0003_1")
-- ▲直接出力

	--★★ギネマウア★★:ギネヴィア！
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310011")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor001,20.0,0.8)
slidemove(Actor002,{-1.097,0.0,0.446},2.5)
slidemove(Actor003,{-0.533,0.0,1.2},2.5)
wait_time(0.8)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(1.7)
setup_small_camera_start(Camera002)
turn_chara(Actor002,130,0.4)
turn_chara(Actor003,140,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(0.5)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:ああ、よかった。ここにいたのね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力

	--★★マーリン★★:探しましたよ。私たちが着替えている間に<br>姿が見えなくなったものですから…
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0310015")


	--★★マーリン★★:「やっぱり嫌になった」なんてことになったら<br>どうしようかと焦ってしまいました
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0310016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:さ、さすがにそんなこと言わないわよ<br>もう来ちゃったんだし
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310017")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0008")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ただ、水着を着てはしゃぐとか<br>そういう気分にはなれないってだけ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310018")

	open_select_window_tag(Actor002,"Normal","EA_069_0310020","EA_069_0310021")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0058")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:もしかして、体調でも悪いの？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310024")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0007")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:えっ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:熱は？朝ごはんもしっかり食べていたし<br>顔色も悪くはないけど…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310026")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:だ、大丈夫！体調は平気よ<br>ただ…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0058")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:私が選んだ水着が気に入らなかったの？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0051")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:そういうわけじゃない<br>カワイイとは思ったし
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310031")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン_005","0038")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:さすがです、ギネマウア様<br>殿下の好みをよくわかっていらっしゃいますね
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0310032")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:確かに、水着は好みでかわいかったけど…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310033")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:そもそもこんなことしてる場合じゃないし<br>もっと勉強して、強くならないと
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310035")


	--★★ギネヴィア★★:だって入学してもう4ヶ月にもなるのに<br>他のクラスメイトに比べてわたし、弱っちいから
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310036")

	change_face(Actor002,"Sad")

	--★★ギネマウア★★:………
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310037")

-- ▼直接出力
change_face(Actor002,"Normal")
setup_small_camera_start(Camera001)
set_pos(Actor004,{5.0,-3.0,1.01})
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:バルバロイと戦うために早くGSしなきゃ<br>そのためにわたし――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310038")


	--★★ギネヴィア★★:………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マーリン★★:…？ギネヴィア様？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0310040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0046")
-- ▲直接出力

	--★★ギネヴィア★★:…スンスン。なに、この匂い<br>芳ばしい匂いが鼻をくすぐる――
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310041")

-- ▼直接出力
se_play("SE_ADV_EA_069_031_Barbecue")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0028")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:おっ！いい感じに肉が焼けてきたぞ！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310042")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera004)
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor001,73,0.6)
turn_chara(Actor002,92,0.6)
turn_chara(Actor003,100,0.6)
wait_time(0.6)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力

	--★★アーサー★★:さあ皆、焦げる前に食べるとしよう！<br>青空の下でバーベキューといこうじゃないか！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310043")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0053")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:人が真面目に悩んでるときに肉を焼くなあ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310044")

-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力

	--★★アーサー★★:いや、スマン！<br>肉を見ていたら我慢できなくなって！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310045")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0033")
-- ▲直接出力

	--★★ギネヴィア★★:あのねえ…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310046")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_EA_069_031_Stomach")
wait_time(2.0)
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Shy")

	--★★ギネヴィア★★:…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310049")

-- ▼直接出力
CloseTalkWindow()
set_pos(Actor004,{5.0,0.0,1.01})
setup_small_camera_start()
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-116,0.4)
wait_time(0.4)
slidemove(Actor004,{1.15,0.0,0.669},1.5)
wait_time(1.5)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:ほら、腹が減っては戦はできぬというし
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310050")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101020_sp_0002_1")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マーリン★★:アーサー様、デリカシーがなさすぎます
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0310051")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0029")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★アーサー★★:え！？俺はかわいいと思うぞ！<br>それに、腹が減るのは生きてる証だ！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310052")

	change_face(Actor004,"Normal")

	--★★アーサー★★:ギネヴィアが頑張っているのは知っている<br>ランスも熱心さを評価していたからな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310053")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★アーサー★★:だが、根を詰めすぎては身になるものもならん<br>闇雲に突き進むだけが道じゃないからな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310055")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0010")
-- ▲直接出力

	--★★アーサー★★:…なんてな。俺もたまには<br>学長らしいことも言えるだろう？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","EA_069_0310056")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0008")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★マーリン★★:ええ。その一言を足さなければ完璧でした
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","EA_069_0310057")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,116,0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101016_sp_0002_1")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネマウア★★:殿下、せっかくのご厚意ですよ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310058")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:………いただきます
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","EA_069_0310059")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor001)
Hide(Actor002)
Hide(Actor003)
Hide(Actor004)
Appear(Actor005)
wait_time(2.0)
setup_small_camera_start(RndCamera003)
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
Appear(Actor006)
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,{0.345,0.0,-0.961},2.0)
wait_time(1.6)
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor005,-81,0.4)
wait_time(0.4)
PlayActionDirect(Actor006,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(1.0)
-- ▲直接出力

	--★★ギネヴィア2★★:…なに
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0310063")


	--★★ギネマウア2★★:口の端、ソースがついてる
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310064")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0029")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ギネヴィア2★★:ウソ！？
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0310065")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0014")
-- ▲直接出力
	change_face(Actor006,"Laugh")

	--★★ギネマウア2★★:こら、手で拭わないの<br>今拭いてあげるから…
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310066")

-- ▼直接出力
CloseTalkWindow()
show_image("201010880", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力

	--★★ギネマウア2★★:はい、これで綺麗になったわ
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","simple","N","EA_069_0310076")


	--★★ギネヴィア2★★:あ――
	Talk(Actor005,"CHRNAME_GUINEVERE","simple","N","EA_069_0310077")


	--★★ギネマウア2★★:？
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","simple","N","EA_069_0310079")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0051")
-- ▲直接出力

	--★★ギネヴィア2★★:…なんでもない<br>あのふたりは？
	Talk(Actor005,"CHRNAME_GUINEVERE","simple","N","EA_069_0310080")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0008")
-- ▲直接出力

	--★★ギネマウア2★★:腹ごなしに少しその辺を歩いてくるそうよ
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","simple","N","EA_069_0310081")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0045")
-- ▲直接出力

	--★★ギネヴィア2★★:へえ――
	Talk(Actor005,"CHRNAME_GUINEVERE","simple","N","EA_069_0310082")

-- ▼直接出力
se_play("SE_ADV_EA_069_031_Growl")
-- ▲直接出力

	--★★イノシシ★★:グルルルルル…
	Talk(Actor007,"NPCNAME_0396","simple","N","EA_069_0310083")

	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")
	on_cutin(2,Actor006,"Surprise")

	--★★ギネ姉妹★★:！？
	Talk(Actor008,"CHRNAME_GUINEVERE_GWENHWYMAWR","simple","N","EA_069_0310084")

	close_cutin()
-- ▼直接出力
CloseTalkWindow()
Appear(Actor007)
turn_lookat(Actor005,Actor007,0)
turn_lookat(Actor006,Actor007,0)
setup_small_camera_start()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0029")
-- ▲直接出力

	--★★ギネマウア2★★:さっき追い払ったイノシシ！？<br>まさか戻ってくるなんて…
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310087")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0002")
-- ▲直接出力
	change_face(Actor005,"Laugh")

	--★★ギネヴィア2★★:もしかしてお腹が空いてるとか？<br>…お肉、食べる？
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0310088")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101016_sp_0003_2")
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★ギネマウア2★★:やめなさい、ギネヴィア！
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310089")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor007,"to std01yell01")
se_play("SE_ADV_EA_069_025_Roar")
bgm_play("BGM_ADV_Antagonism")
-- ▲直接出力

	--★★イノシシ★★:ガアアアアッ！
	Talk(Actor007,"NPCNAME_0396","speech","N","EA_069_0310090")

-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0,0.5)
wait_time(0.5)
se_play("SE_ADV_MA_01C900_19_Punch")
fadein(0.5)
PlayActionDirect(Actor006,"to Sit10")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0043")
-- ▲直接出力
	change_face(Actor006,"Pain")

	--★★ギネマウア2★★:…痛ッ！！
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310094")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
voice_play("VO_101011_sp_0003_2")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ギネヴィア2★★:お姉ちゃん！？
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0310095")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0043")
-- ▲直接出力

	--★★ギネマウア2★★:これくらい平気よ<br>それより気を付けて――来るわ！
	Talk(Actor006,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0310096")

-- ▼直接出力
bgm_play("BGM_Battle_General1_Intro")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Antagonism")
preload_sound("BGM_Battle_General1_Intro")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("201010880", "content_still_20101088_image", "201010880_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101050011)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","005","101020005","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101016","004","101016004","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201017","001","201017001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
