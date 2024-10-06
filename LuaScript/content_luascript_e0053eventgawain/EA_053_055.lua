-- このluaスクリプトは、EA_053_055.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-41,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",-65,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",-9,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera004 = SetTemplate("Actor004",-140,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_020_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	Camera005 = SetTemplate("Actor005",125,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera006 = SetTemplate("Actor006",125,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera007 = SetTemplate("Actor007",198,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera008 = SetTemplate("Actor008",-148,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
BgProp = setup_prop_object(10102009)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{ -1.29, 0, 0.66})
set_pos(Actor002,{ -1.15, 0, 1.45})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{ -1.82, 0, 0.27})
set_pos(Actor004,{ 0.5, 0, 4.5})
--set_pos(Actor004,{ -1.2, 0, 2.3})
set_pos(Actor005,{ -2.48, 0, 2.04})
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{ -2.08, 0, 2.51})
set_pos(Actor005,{ -2.48, 0, 2.04})
set_pos(Actor007,{ -1.37, 0, 2.6})
set_pos(Actor008,{ -0.8, 0, 2.35})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor006,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor005,Actor002,"J_Head")
keep_ik_lookat(Actor006,Actor002,"J_Head")
keep_ik_lookat(Actor007,Actor002,"J_Head")
keep_ik_lookat(Actor008,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101033","003","101033003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("401014","001","401014001","content_animationpack__common","FacialPack","Actor008")
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("リオネス","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:さあさあ、皆おまちどうさま！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0550004")

-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0026")
-- ▲直接出力

	--★★リオネス★★:五月祭限定！キャメロット学園食堂プレゼンツの<br>すっごく美味しいお菓子！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0550005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リオネス★★:今日しか食べられない絶品スイーツ<br>ほしい人は集合だー！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0550006")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("子供_女1","0012")
-- ▲直接出力

	--★★子供A★★:
	Talk(Actor005,"NPCNAME_0140","speech","L","EA_053_0550007")

	PlayAction(Actor008,"to Greet_one")

	--★★女性★★:私にも！
	Talk(Actor008,"NPCNAME_0182","speech","L","EA_053_0550008")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★男性★★:俺にも！
	Talk(Actor007,"NPCNAME_0177","speech","L","EA_053_0550009")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0033")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:あー、ほらほら押すなって！<br>リオネスが潰れちまうだろ！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550010")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール★★:お菓子はたくさん用意してあるから<br>順番にもらっていってくれ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0550011")

-- ▼直接出力
CloseTalkWindow()
change_face(Actor001,"Laugh")
wait_time(0.5)
setup_small_camera_start(Camera001)
wait_time(0.5)
turn_chara(Actor005,27,0.5)
turn_chara(Actor006,-118,0.5)
set_pos(Actor007,{ -0.8, 0, 4.5})
turn_chara(Actor007,15,0)
wait_time(0.5)
Hide(Actor008)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("子供_女1","0002")
-- ▲直接出力

	--★★子供A★★:ねえねえ、ガウェイン！<br>これ、超美味しいよ！
	Talk(Actor005,"NPCNAME_0140","speech","L","EA_053_0550012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0055")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:お、そうか？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550013")

-- ▼直接出力
PlayPartVoiceDirect("子供_女1","0007")
change_face(Actor001,"Laugh")
-- ▲直接出力

	--★★子供A★★:うん！甘くてサックサクで！口の中から幸せになる感じがする！
	Talk(Actor005,"NPCNAME_0140","speech","L","EA_053_0550014")

-- ▼直接出力
CloseTalkWindow()
Hide(Actor007)
Hide(Actor008)
wait_time(0.3)
setup_small_camera_start(RndCamera005)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002, 8, 0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Std_Loop")
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0045")
PlayActionDirect(Actor002,"to Greet_one")
-- ▲直接出力

	--★★子供B★★:僕のは見た目ちょっと不格好だけど…<br>でも、美味しい！むしろこの不格好さも味かも？
	Talk(Actor006,"NPCNAME_0141","speech","L","EA_053_0550015")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("子供_女1","0047")
-- ▲直接出力

	--★★子供A★★:えー、いいないいな！交換っこしようぜ！
	Talk(Actor005,"NPCNAME_0140","speech","L","EA_053_0550016")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男1","0038")
-- ▲直接出力

	--★★子供B★★:いいよー！
	Talk(Actor006,"NPCNAME_0141","speech","L","EA_053_0550017")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor005,"to Run")
turn_chara(Actor005,-55,0.3)
PlayActionDirect(Actor006,"to Run")
turn_chara(Actor006,-55,0.25)
wait_time(0.3)
slidemove(Actor005,{-4.929, 0, 3.947},2)
slidemove(Actor006,{-4.994, 0, 4.865},2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002, -65, 0.4)
wait_time(0.4)
PlayActionDirect(Actor002,"to Greet_one")
wait_time(1.8)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor005,"to Std_Loop")
PlayActionDirect(Actor006,"to Std_Loop")
Hide(Actor005)
Hide(Actor006)
wait_time(1)
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:だってよ、ノワール！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550019")

-- ▼直接出力
setup_small_camera_start(Camera003)
change_face(Actor002,"Normal")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:嬉しい…けど、ちょっと悔しいな
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0550020")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0012")
PlayActionDirect(Actor003,"to  Std_Joy")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:次に作るときはもっと上手に<br>作れるようになってやるぞ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0550022")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor001, 0.45, 0.5, 0.85, 0.2, 0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:お菓子作りに目覚めちゃった！？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0052")
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:…ま、気持ちはちょっとわかるけどなあんな幸せそうな顔見せられちゃ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550024")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
lookat_delay_weight(Actor001, 0.45, 0.5, 0.85, 0.2, 0.3)
-- ▲直接出力

	--★★ガウェイン★★:皆、いい笑顔だ<br>…なんか俺、大事なこと忘れてた気がする
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550025")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0010")
-- ▲直接出力

	--★★ガウェイン★★:そうだよ。俺――この笑顔が見たくて<br>ヒーローを目指したんだ
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550026")

-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0054")
-- ▲直接出力

	--★★ガウェイン★★:あの人が、俺たちを笑顔にしてくれたみたいに<br>誰かを笑顔にできるヒーローになりたくて――
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550027")

-- ▼直接出力
CloseTalkWindow()
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
lookat_delay_weight(Actor003, 0.45, 0.5, 0.85, 0.2, 0.3)
PlayActionDirect(Actor003,"to Wlk")
turn_chara(Actor003, 10, 0.4)
wait_time(0.4)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力

	--★★ノワール★★:じゃあ、ガウェインは<br>ずっとこの街のヒーローだったわけだ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0550028")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1.0)
lookat_delay_weight(Actor001, 0.45, 0.5, 0.85, 0.2, 0.3)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001, -72, 0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:え？
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550029")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ノワール★★:だって、ガウェインに助けてもらった人たちは<br>皆あんな風に、嬉しそうに笑ってたからさ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0550030")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力

	--★★ガウェイン★★:…！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0048")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:…そっか。俺、ちゃんとヒーローやれてたんだな<br>へへ…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550032")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン","0012")
PlayActionDirect(Actor001,"to  Std_Joy")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:…あー！なんかやる気出てきたー！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550034")

	change_face(Actor001,"Anger")

	--★★ガウェイン★★:忙しいがなんだ！<br>この笑顔のためならいくらでも頑張れる！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550035")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Smile")

	--★★ガウェイン★★:皆の笑顔が、<ruby=ヒーロー>俺</ruby>の力になるからな！
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550036")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力

	--★★ノワール★★:やる気なのはいいけど、あんまり無理するなよ
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0550038")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ノワール★★:俺にできることがあれば手伝うしさ<br>今回みたいに
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0550039")

-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101013_sp_0001_3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガウェイン★★:ノワール…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550040")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004, -1.2, 0, 2.1, 2)
wait_time(1.6)
turn_chara(Actor004, -180, 0.4)
setup_small_camera_start(Camera007)
wait_time(0.38)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",1.0)
lookat_delay_weight(Actor002, 0.45, 0.5, 0.85, 0.2, 0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0008")

keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
lookat_delay_weight(Actor001, 0.45, 0.5, 0.85, 0.2, 0.3)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001, -15, 0.4)
wait_time(0.4)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★コック長★★:お、そいつはいいな！<br>またイベントのときは頼むぜ
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0550042")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:コック長！あんた、怪我はもういいのか？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_053_0550043")

-- ▼直接出力
setup_small_camera_start(Camera007)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0007")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★コック長★★:あれくらいなんともねェよ！<br>それより…色々サンキューな、ふたりとも！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0550044")

	change_face(Actor004,"Normal")

	--★★コック長★★:おまえさんたちのおかげで<br>食堂に来る客だけじゃなく
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0550045")

	PlayAction(Actor004,"to  Std_Joy")

	--★★コック長★★:街のみんなを笑顔にすることができた<br>さすがだぜ、ヒーロー！
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0550046")

-- ▼直接出力
setup_small_camera_start(Camera001)
change_face(Actor003,"Laugh")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガウェイン★★:コック長…
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550047")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("グリフレット","0011")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★コック長★★:今度なにかイベントやるときには<br>またオレっちたちで街の皆を笑顔にしようぜ
	Talk(Actor004,"NPCNAME_0260","speech","L","EA_053_0550048")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("リオネス_003","0012")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★リオネス★★:おー！いいないいな！次が楽しみだ！<br>皆でやれば、なんだってできそうだもんな！
	Talk(Actor002,"CHRNAME_LYONESS","speech","L","EA_053_0550049")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ガウェイン_004","0008")
PlayActionDirect(Actor001,"to  Std_Worry")
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★ガウェイン★★:皆で…か<br>――そうだな
	Talk(Actor001,"CHRNAME_GAWAIN","speech","L","EA_053_0550050")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102009)
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101013","004","101013004","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101033","003","101033003","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401029","001","401029001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("401014","001","401014001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
