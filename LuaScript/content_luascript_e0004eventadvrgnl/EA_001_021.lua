-- このluaスクリプトは、EA_001_021.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_02","112021_02_h")
Include("content_adv_advsmall_112021_02","Template112021_02_h")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_001)
	Camera006 = SetTemplate("Actor006",49,CharaPos112021_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos112021_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos112021_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_008)
	Camera009 = SetTemplate("Actor009",90,CharaPos112021_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_003)
	InitializeTemplateRandomCamera112021_02()
	InitializeTemplate112021_02()
-- ▼直接出力
 --MobM040 = get_object("m040")
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
sakana = setup_prop_object(10108006)
set_pos(sakana, {0,0,0})
set_rot(sakana, {0,0,0})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
set_pos(Actor007, {-2,0,1.642})
set_rot(Actor007, {0,90,0})
-- ▲直接出力
-- ▼直接出力
Hide(Actor008)
set_pos(Actor008, {-2.5,0,0.718})
set_rot(Actor008, {0,90,0})
-- ▲直接出力
-- ▼直接出力
hideobj01 = get_object("obj_left")
hideobj02 = get_object("obj_right")
set_pos(hideobj01,{0,-20,0})
set_pos(hideobj02,{0,-20,0})
set_pos(Actor009, {-3,0,0})
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera003 = SetTemplate("Actor003",-130,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera008 = SetTemplate("Actor008",nil,CharaPos112021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_008)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
 --sakana = setup_prop_object(プロッププランナーID)
 --set_pos(sakana, {0,0,0})
 --set_rot(sakana, {0,0,0})
 --off_active(sakana)
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
set_pos(Actor002, {4.8,0,0.13})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力

set_pos(Actor007, {-4.27, 0, -0.03,   90})
set_rot(Actor007, {0,90,0})
-- ▲直接出力
-- ▼直接出力

set_pos(Actor008,{-4.27, 0, -0.03,   90})
set_rot(Actor008, {0,90,0})
-- ▲直接出力
-- ▼直接出力
CameraProp = set_camera({2.15,2.05,-0.51,27.252,180,0,22})
-- ▲直接出力
-- ▼直接出力
CameraEX = set_camera({3.999, 2.115, 1.72,13.38201, 249.9478, 359.9351,22})
-- ▲直接出力
-- ▼直接出力
load_image("104000200", "content_still_10400020_image", "104000200_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401020","001","401020001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor009")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0010")

-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:燃えてるね、おにーさん！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021002")

	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("市民_男1", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★市民（男）★★:せっかくの祭りだ！ド派手な飾り付けは任せな！<br>円卓の騎士様たちを盛り立ててやんねーとな！
	Talk(Actor005,"NPCNAME_0193","speech","N","EA_001_021003")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0047")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:期待しちゃう～っ！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021004")

-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("市民中年_女1", "挨拶")
-- ▲直接出力

	--★★市民（中年女）★★:ラグネル！<br>五月祭のとき王様はマーケットまで来るかねえ？
	Talk(Actor006,"NPCNAME_0194","speech","N","EA_001_021006")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-100,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0026")
-- ▲直接出力

	--★★ラグネル★★:どしたのオバちゃん！アーサー様に会いたいの？<br>言っとくよ！楽しいお祭りにしよーね～！！ 
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021007")

	PlayAction(Actor009,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("男子1", "笑い")
-- ▲直接出力

	--★★男子生徒★★:ラグネル！<br>売り上げ負けないからな！！
	Talk(Actor009,"NPCNAME_0001","speech","N","EA_001_021008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定3")
-- ▲直接出力

	--★★ラグネル★★:あっ、素人料理同好会の人！<br>いいね！燃えてるね！がんばろーね～っ！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021009")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor005)
Hide(Actor006)
Hide(Actor009)
template2()
set_enable_auto_lookat(Actor003, true)
change_face(Actor001,"Normal")
turn_chara(Actor001,31,0)
wait_time(0.2)
MobM040 = get_object("m040")
set_pos(MobM040,{-0, -20.0, 0})
setup_small_camera_start()
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
IN_WALK(Actor002,CharaPos112021_01_002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ローラ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:手芸品の出店で売上が良かったことなんてないし<br>４月の部活勧誘もうまくいかなくて…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0017")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ラグネル★★:声が小さくて聞こえない！！<br>売上なんて時の運だし！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021012")


	--★★ラグネル★★:勧誘がうまくいかなかったのは<br>ノワールの転入とかでバタバタしてたからだし！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021013")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:全部聞こえてるじゃないか<br>あと俺のせいにするな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021014")

-- ▼直接出力
 --プロップが実装されたらここで表示
CloseTalkWindow()
setup_small_camera_start(CameraProp)
 --turn_chara(Actor001,160,0)
 --turn_chara(Actor002,-180,0)
 --turn_chara(Actor003,-180,0)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:見てよ、カワイイでしょ！<br>徹夜で作ってるんだよ、お魚さんのぬいぐるみ！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021016")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:確かに、すごい完成度だ………<br>数も…これ何十、何百個あるんだ？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021018")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0011")
-- ▲直接出力

	--★★ラグネル★★:<ruby=あたし>手芸サークル部長</ruby>の実力を見たか！<br>まだまだ作るよ、ブリテン中に売るんだから
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021019")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ノワール★★:一個、売ってもらってもいいか？<br>妹に──
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021020")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0036")
-- ▲直接出力

	--★★ラグネル★★:わっ、ありがと～！いいよあげるよっ！<br>ディナタンちゃん喜んでくれるかな
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021021")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_reset(Actor002 , 0.6)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,20,0.5)
wait_time(0.5)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ローラ", "0002")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ローラ★★:じゃ、じゃあ私の作った服も見る…？<br>妹さん、似合いそうだし…っ
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021023")

-- ▼直接出力
ShowImageItem("104000200")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0047")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:こ…これも、首元のデザインが抜群だ…！<br>シルエットも可愛らしいし、素人仕事じゃないぞ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021024")

-- ▼直接出力
HideImageItem()
setup_small_camera_end()
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:…こんなにしっかりしてるのに<br>なんで売れないん──…んっ？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021025")

	change_face(Actor003,"Surprise")

	--★★ノワール★★:服のサイズが…ぜんぶ<br>…ぜんぶちょっとディナタンには大きいような…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ローラ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ローラ★★:あっ、わかる…？ふふふ…<br>ぜんぶお姉ちゃんの寸法にピッタリなんだ
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021028")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定3")
-- ▲直接出力

	--★★ラグネル★★:カワイイ～っ<br>双子だとサイズ同じだから着回しできていいね～
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021029")

	change_face(Actor003,"Sad")

	--★★ノワール★★:………あの、ぬいぐるみも、ぜんぶ<br>お魚さんしかいないんだけど
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:そうだよ？可愛さを追求した極地がソレなの<br>ヒレの感じとか、おめめのクリクリ感とか
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021031")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0048")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:や、可愛いけど、似たようなお魚さんばっかり…<br>ほかにはないのか？ほかの動物とかは──
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021032")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-140,0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Appl")
-- ▼直接出力
PlayPartVoiceDirect("ローラ", "0027")
-- ▲直接出力

	--★★ローラ★★:カワイイ…！<br>やっぱり極めるとディティールは絞られるよね
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021033")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor004,Camera004,EntryData112021_01_05,CameraAssetBundleName112021_01,CameraPos112021_01_105)
-- ▲直接出力
-- ▼直接出力
turn_chara(Actor002,-70,0)
PlayPartVoiceDirect("イゾルデ","0007")
-- ▲直接出力

	--★★イゾルデ★★:見極めるべきは、<ruby=ウィークポイント>敵の急所</ruby>ね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021035")

-- ▼直接出力
setup_small_camera_end()
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-50,0.5)
wait_time(0.5)
lookat_delay_weight(Actor001, 0.8,0.03,0.5,0,0.8)
keep_ik_lookat(Actor001, Actor004, "J_Head")
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:イゾルデちゃん！！！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021037")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:今日も小さいねえ！！<br>ナデナデ！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021040")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0013")
-- ▲直接出力

	--★★イゾルデ★★:身長は日々更新中、晩成型なの
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力

	--★★ラグネル★★:じゃあやっぱり毎日サークル来てよ！<br>日々成長するイゾルデちゃんを抱きしめたいっ！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021043")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "否定")
-- ▲直接出力

	--★★イゾルデ★★:それが嫌だから来ない
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021044")

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{0.62,0,0.482,},0.5)
wait_time(0.3)
turn_chara(Actor001,-107.725,0.3)
setup_small_camera_start(CameraEX)
slidemove(CameraEX,{3.59, 2.011,1.571},6.0)
SkipDefaultMotion(Actor001)
PlayAction(Actor001,"to  Std_Joy")
play_head_motion(Actor001, "No", 0.3,0.6,true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ラグネル★★:いけずぅ～～～！！<br>そこが愛らしい～～～！！ぐりぐり！！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021045")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
PlayPartVoice("イゾルデ", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★イゾルデ★★:お前、やめっ、ぐりぐりしないで、お前<br>ちょっと、離しなさ──なでないで、お前
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021046")

-- ▼直接出力
setup_small_camera_start(Camera003)
set_pos(Actor001, {1.082,0,-0.05})
turn_chara(Actor001,-36,0.5)
change_face(Actor001,"Normal")
stop_head_motion(Actor001)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ノワール★★:えーと、イゾルデ<br>話を戻すけど<ruby=ウィークポイント>敵の急所</ruby>って…？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:ケイ先生の急所はどこだと思う？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021049")

	open_select_window_tag(Actor003,"Normal","EA_001_021051","EA_001_021052","EA_001_021053")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0034")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:フィジカルが弱いところ…とか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021055")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0011")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラグネル★★:わっかる！弱そう！<br>力づくで行けってこと？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021056")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0008")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:まあ…ケイ先生自身をブン殴れでもしたら<br>解決することもあるでしょうけれど
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021057")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ローラ","0014")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:発生する問題のほうが多そう…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021058")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0034")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:内臓が、弱そう
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021060")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "照れ")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:想像でモノを言うのはやめなさい<br>仮にそれが真だったとしてどう攻めるの？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021061")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ローラ", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ローラ★★:辛い物を食べさせて、お腹を壊させて<br>トイレに行かせずに脅迫するとか…？
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021062")

-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0043")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★イゾルデ★★:…あ、案外怖い発想をするのね<br>我らの宰相をそんな扱いしてはダメよ
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021063")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール", "0034")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:実利にこだわり過ぎるところに<br>なにか突破口はないかな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021065")

	change_face(Actor001,"Sad")

	--★★ラグネル★★:じ、つ、り………？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021066")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ローラ", "0032")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ローラ★★:実際の…利益を重視している<br>…ということかな？
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021067")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "笑い")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★イゾルデ★★:いいところを突いているわ、ノワール<br>さすがはスピード出世の円卓の騎士ね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021068")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.2)
IN_WALK_2P(Actor007,CharaPos112021_01_006,Actor008,CharaPos112021_01_008)
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("兵士1", "挨拶")
-- ▲直接出力

	--★★ログレス兵★★:オイ、話は済んだのかよ、オォ？
	Talk(Actor007,"NPCNAME_0363","speech","N","EA_001_021070")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ラグネル","0032")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ラグネル★★:ウワア！<br>ガラの悪そうな兵士さんたち！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021071")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:そう、ガラが悪いうえに身なりも悪い<br>ケイ先生お付きの兵からそんな人を選んできたわ
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021072")

	play_head_motion(Actor008, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("山賊","0032")
-- ▲直接出力

	--★★キャメロット軍兵士_下位★★:身なりなんぞ<br>整えてる暇がねえんだよ
	Talk(Actor008,"NPCNAME_0364","speech","N","EA_001_021073")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ローラ", "0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:こ、こわい…<br>ケイ先生には似合わないような…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021074")


	--★★イゾルデ★★:<dot>ないもの</dot>こそ<br>身の回りにあるもので補強するのでしょうね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021075")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ないもの…<br>つまり、ケイ先生の急所は──
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021076")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力

	--★★イゾルデ★★:ケイ先生の急所はふたつ<br>ひとつ目は『フィジカルの弱さ』
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021077")


	--★★イゾルデ★★:その弱さゆえに兵の一部──<br>荒くれ者を持て余してしまっている
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021078")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("兵士1", "納得")
-- ▲直接出力

	--★★ログレス兵★★:<ruby=ゲシュタルト・シフト>ＧＳ</ruby>とやらが化け物との戦いの要だっつうがよ<br>頼りなさそうなヒョロガキどもだな、本当に
	Talk(Actor007,"NPCNAME_0363","speech","N","EA_001_021079")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)

	--★★キャメロット軍兵士_下位★★:ケイ卿のお達しでこの場所は<br>風紀委員会の監視員が使うことになった。消えな
	Talk(Actor008,"NPCNAME_0364","speech","N","EA_001_021080")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:…ケイが出した大雑把な廃部撤回条件といい<br>本気で手芸サークルを潰す気でいるな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021081")

-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0013")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ラグネル★★:ケンカを買えば…いいのかな？
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021083")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定")
-- ▲直接出力

	--★★イゾルデ★★:学生に命は預けられないとその力を疑う兵は多い<br>ケイ先生が手を焼くほどにね
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021084")


	--★★イゾルデ★★:このままではキャメリアード攻めにも支障が出る<br>そうケイ先生はひそかに頭を抱えている
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021085")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★イゾルデ★★:そこでケイ先生の急所、ふたつ目<br>『実際の利益にこだわるトコロ』を突く
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021086")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0013")
-- ▲直接出力
	change_face(Actor004,"Laugh")

	--★★イゾルデ★★:彼らを<dot>説得</dot>するの
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021087")

	PlayAction(Actor007,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("兵士1", "笑い")
-- ▲直接出力

	--★★ログレス兵★★:ガキどもの力はいつか見てみてえと思ってたんだ<br>懐柔なんざされねえぞ、力づくで来るんだな
	Talk(Actor007,"NPCNAME_0363","speech","N","EA_001_021089")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ローラ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ローラ★★:兵士さんたちに私たちの力を示すことができれば<br>そうやってケイ先生の利益になれば…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","EA_001_021090")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★イゾルデ★★:見逃すことはできないはず。どう？
	Talk(Actor004,"CHRNAME_ISOLDE","speech","L","EA_001_021091")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ラグネル", "0017")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ラグネル★★:だめね
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021092")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:だよな…<br>そんな憶測とノリだけで兵士とケンカなんて──
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021093")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★ラグネル★★:あたしたちには<br>達成しなきゃならない偉業がある
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021094")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight(Actor002, 0.8,0.03,0.6,0,0.8)
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ローラ", "納得")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Surprise")

	--★★ローラ★★:…ブリテンのみんなに<br>ぬいぐるみを欲しがらせるという偉業…！
	Talk(Actor002,"CHRNAME_LOLA","speech","N","EA_001_021096")

	close_cutin()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:だからそれはムリだって<br>なんだそれどうなれば達成なんだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021097")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ラグネル★★:ケンカは買う！力は示す！<br>それとついでにぬいぐるみを売る！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021098")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ノワール★★:なんだそれどうするんだ！？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_021099")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラグネル★★:ノワールはオジサンたちに腕力を示して！<br>あとはあたしたちがなんとかするから！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021100")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor007,"J_Head",0.8)
PlayPartVoiceDirect("ローラ","0035")
-- ▲直接出力

	--★★ラグネル★★:手加減しないよ──…できないし！
	Talk(Actor001,"CHRNAME_RAGNAR","speech","L","EA_001_021101")

	EndPlay()
end

