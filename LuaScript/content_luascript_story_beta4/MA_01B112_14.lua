-- このluaスクリプトは、MA_01B112_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_02","112021_02_h")
Include("content_adv_advsmall_112021_02","Template112021_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_002)
	Camera003 = SetTemplate("Actor003",24.2,CharaPos112021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_001)
	Camera004 = SetTemplate("Actor004",191.6738,CharaPos112021_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_003)
	Camera005 = SetTemplate("Actor005",221.5526,CharaPos112021_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_005)
	InitializeTemplateRandomCamera112021_02()
	InitializeTemplate112021_02()
-- ▼直接出力
hotdog = setup_prop_object(10102001)
hotdog_offset = {0,0,0,0,0,0}
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to EatIdle")
on_parent(hotdog,Actor002, "Loc_weapon_constrint_R", hotdog_offset)
set_pos(Actor004,{0.432,0,2.642})
set_pos(Actor005,{3.025,0,1.32})
Hide(Actor004)
Hide(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116024)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera002)
change_face(Actor002,"Sad")
play_head_motion(Actor002, "No", 0.3, 1.0, false)
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…忘れてくれ<br>見なかったことにしてくれ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140002")


	--★★ガラハッド★★:買い食いなどという<br>不良な行為に身をやつす僕を…っっ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140004")

-- ▼直接出力
change_face(Actor002,"Anger")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:そ、それにそれに非行少女が言ってたからっ<br>サボれるときにサボれと…！ただそれだけだっ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:まだなにも言ってないぞ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140006")

	open_select_window_tag(Actor001,"Normal","MA_01B112_140007","MA_01B112_140008","MA_01B112_140009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なにを食べてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140011")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:…『クムピル』という食べ物らしい<br>美味しいうえに自由にトッピングできるんだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140012")

-- ▼直接出力
change_face(Actor002,"Surprise")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ログレスは賑やかだな<br>歩くたびに珍しいものに出会える
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140013")

-- ▼直接出力
change_face(Actor002,"Smile")
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:もちろんコルベニック城の静穏を愛しているが<br>たまにはこんな喧騒にまみれるのも悪くない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:だいぶ街に馴染んできたみたいだな<br>すぐにガラハッドだとわからなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:この街に滞在して随分経つしな<br>もう道案内なしでも行きたい場所に行ける
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:馴染みの店なんかも<br>できたんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140018")

-- ▼直接出力
change_face(Actor002,"Sad")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:それは、その、まだ、あまり…<br>というかぜんぜん…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140019")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:この街のみんなはいい人ばっかりだ<br>ゆっくり仲良くなっていけばいいさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺も買い食いしよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Surprise")
-- ▲直接出力
-- ▼直接出力
play_head_motion(Actor002, "No", 0.3, 1.0, false)
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:い、いけないぞノワール！<br>買い食いはクセになってしまう！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140023")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ガラハッドの真似をさせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140024")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:…！ふたりで買い食いか<br>それは…学園で誰かもやっていた…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140025")

-- ▼直接出力
change_face(Actor002,"Smile")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:これは、オツというやつだな<br>ふふ、これは、ちょっとイイな…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140026")

-- ▼直接出力
change_face(Actor002,"Smile")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:この街の屋台の<br>食べ物の充実ぶりは目を見張るものがあるな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140028")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それは国王の影響じゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140029")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
off_active(hotdog)
-- ▲直接出力
-- ▼直接出力
off_parent(hotdog)
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Run")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Run")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor004,-0.402,0,-1.395,1.8)
-- ▲直接出力
-- ▼直接出力
slidemove(Actor005,0.705,0,-1.293,1.8)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,-189.8,0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("子供_男1", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★子供（男）★★:おじさん！クムピルアーサーセットちょうだい！
	Talk(Actor004,"NPCNAME_0140","speech","N","MA_01B112_140031")

	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("子供_男2", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★子供（男）②★★:ぼくもー！
	Talk(Actor005,"NPCNAME_0141","speech","N","MA_01B112_140032")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("市民_男1", "肯定3")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★市民（男）★★:はいよ<br>こぼれやすいから気を付けて食べるんだぞ
	Talk(Actor003,"NPCNAME_0119","speech","N","MA_01B112_140033")


	--★★子供たち★★:はーい！
	Talk(Actor006,"NPCNAME_0144","speech","N","MA_01B112_140034")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:アーサーセット？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140035")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("市民_男1", "笑い")
-- ▲直接出力

	--★★市民（男）★★:アーサー様お気に入りのトッピング全部盛り<br>ソースたっぷりギットギトの特別セットだよ
	Talk(Actor003,"NPCNAME_0119","speech","N","MA_01B112_140036")

	PlayAction(Actor003,"to  Std_Talk")

	--★★市民（男）★★:アーサー様はこいつをよく<br>子どもたちといっしょに食べてるんだ
	Talk(Actor003,"NPCNAME_0119","speech","N","MA_01B112_140037")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:アーサー王は<br>民との触れ合いを大切にしているんだな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140038")

-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:まあ、自分がB級グルメを食べたいってのも<br>大きいだろうけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140039")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:お爺様も昔はああやって<br>城下町に行ってはみんなと触れ合っていた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140041")


	--★★ガラハッド★★:ガラハッドにももちろん優しくて<br>どんなワガママも聞いてくれた
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("子供_男2", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★子供（男）②★★:ねえ、おじさん<br>今年の降誕祭は中止になっちゃうの？
	Talk(Actor005,"NPCNAME_0141","speech","N","MA_01B112_140044")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("子供_男1", "悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★子供（男）★★:パパもママも言ってた<br>みんな大変なときだから我慢しなさいって
	Talk(Actor004,"NPCNAME_0140","speech","N","MA_01B112_140045")

	PlayAction(Actor004,"to  Std_Sad02")
	change_face(Actor004,"Sad")

	--★★子供（男）★★:でも、残念だよね<br>楽しみにしてたのに
	Talk(Actor004,"NPCNAME_0140","speech","N","MA_01B112_140046")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★子供（男）②★★:ね～。アーサー様だって<br>「絶対にやるぞ」って言ってたのになぁ
	Talk(Actor005,"NPCNAME_0141","speech","N","MA_01B112_140047")

	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:降誕祭…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B112_140049","MA_01B112_140050")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:この状況じゃ、さすがに無理じゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140052")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:…普通に考えたら、そうだろうな<br>ガラハッドもそう思う
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140053")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:でも皆が感じている不安を<br>賑やかな催しで少しでも払拭できるなら
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140054")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:ガラハッドは、やる価値があると思う
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140055")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:降誕祭をやろうって<br>みんなに提案してみないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140057")

	change_face(Actor002,"Normal")

	--★★ガラハッド★★:たとえ一時でも<br>不安を忘れてもらおうと？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140058")

	change_face(Actor001,"Normal")

	--★★ノワール★★:違うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140060")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:バルバロイなんて怖くない<br>世界はまだまだ続いていく、それを伝えるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B112_140061")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:…！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140062")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そうだな！いい案だとガラハッドも思う！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140063")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(RndCamera011)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:…皆！心配いらないぞ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140065")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ガラハッド★★:円卓騎士のひとり、ノワール卿が<br>降誕祭を開くために働きかけてくれるそうだ
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("子供_男1", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★子供（男）★★:ほんと！？
	Talk(Actor004,"NPCNAME_0140","speech","N","MA_01B112_140068")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("子供_男2", "納得")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★子供（男）②★★:降誕祭、やってくれるの？
	Talk(Actor005,"NPCNAME_0141","speech","N","MA_01B112_140069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:ああ。もちろん、銀卓騎士団がひとり<br>ガラハッドも開催に向けて全面的に協力する！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140070")

	change_face(Actor002,"Anger")

	--★★ガラハッド★★:大変なことはすべて打倒し<br>必ずやお祭り騒ぎを取り戻すぞ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:どうだ、ノワール？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140074")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:負けるわけには、いかなくなったな
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","MA_01B112_140076")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102001)
hotdog_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(116024)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
