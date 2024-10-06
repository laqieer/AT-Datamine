-- このluaスクリプトは、MA_01107_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_02","112021_02_h")
Include("content_adv_advsmall_112021_02","Template112021_02_h")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_004)
	Camera002 = SetTemplate("Actor002",-120,CharaPos112021_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_003)
	Camera003 = SetTemplate("Actor003",-160,CharaPos112021_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_002)
	Camera004 = SetTemplate("Actor004",-180,CharaPos112021_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_007)
	Camera005 = SetTemplate("Actor005",-180,CharaPos112021_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_006)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_02,CameraPos112021_02_001)
	InitializeTemplateRandomCamera112021_02()
	InitializeTemplate112021_02()
-- ▼直接出力
load_image("103010370", "content_still_10301037_image", "103010370_StillImage")
set_common_look_at(Actor002,Actor001)
set_common_look_at(Actor003,Actor001)
set_pos(Actor004,{1.1,0,1.6})
set_pos(Actor005,{0.6,0,1.4})
Hide(Actor004)
Hide(Actor005)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos112021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_008)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
set_pos(Actor004,{1.691,0,0.512})
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フレン★★:小腹がすいたの<br>だけどお小遣いがないのよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080002")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
turn_chara(Actor001,120,0.5)
lookat_delay_weight(Actor002,0.7, 0.03, 0.7, 0,1)
lookat_delay_weight(Actor003,1.0, 0.03, 0.7, 0,1)
-- ▲直接出力

	--★★フレン★★:ローラは？食べない…？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ローラ★★:私はお姉ちゃんが食べるなら食べる
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01107_080004")

	PlayAction(Actor001,"to  Std_Angry")

	--★★フレン★★:ラシア！君は！？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080005")


	--★★ラシア★★:無駄遣いは<br>叔父様に止められているから
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01107_080006")

-- ▼直接出力
OpenFirstAppearance(Actor003)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フレン★★:クッ、主体性のないやつらめぇ…！
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080007")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Talk")
turn_chara(Actor003,-125,0.3)
-- ▲直接出力

	--★★ラシア★★:私たちに聞いてる時点で<br>フレンもそうじゃない？
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01107_080008")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor004)
Appear(Actor005)
PlayActionDirect(Actor004,"to Wlk")
slidemove(Actor004,{1.1,0,0},1)
wait_time(0.7)
turn(Actor004,0,-125,0,0.3)
PlayActionDirect(Actor004,"to Std_Loop")
PlayActionDirect(Actor005,"to Wlk")
slidemove(Actor005,{0.6,0,0.6},0.5)
wait_time(0.2)
turn(Actor005,0,-145,0,0.3)
PlayActionDirect(Actor005,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ルーシャス★★:店主<br>ぜんぶ寄越せ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080010")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor004)
PlayActionDirect(Actor004,"to Greet_one")
turn_chara(Actor004,-110,0.3)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ルーシャス★★:やあ。奇遇だな…フレンとフレン妹<br>それに将軍お気に入りの娘よ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080012")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
template2()
set_pos(Actor006,{-1,0,-3.4})
set_rot(Actor006,{0,0,0})
change_face(Actor001,"Normal")
lookat_delay_weight_reset(Actor001,1)
lookat_delay_weight_reset(Actor002,1)
lookat_delay_weight_reset(Actor003,1)
lookat_delay_weight_reset(Actor004,1)
lookat_delay_weight_reset(Actor005,1)
setup_small_camera_start()
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Worry")
-- ▲直接出力

	--★★ルーシャス★★:せっかく買ってやったのだ<br>好きなだけ胃袋に詰め込むがいい
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080014")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★フレン★★:好きなだけって、なに考えてるの…！？<br>こんなに食べられないし…もらえないよ！
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080016")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ルーシャス★★:小腹がすいたのではなかったのか？<br>余ったものは捨ててかまわぬが
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080018")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★フレン★★:ルーシャスくん<br>君、ちょっとおかしいよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ラシア★★:こ、皇太子殿下だよ、フレン
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01107_080021")


	--★★ヴェルナルス★★:フレン<br>ルーシャス様に向かって無礼だぞ
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","MA_01107_080023")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor005,true)
reserve_eyesync(Actor004,"Close")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ルーシャス★★:将軍<br>我が友人に向かって失礼だぞ？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080024")

	change_face(Actor001,"Normal")

	--★★フレン★★:友人になったつもり、ないけど
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080026")

-- ▼直接出力
reserve_eyesync(Actor004,"Auto")
set_enable_auto_lookat(Actor005,false)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_No")
-- ▲直接出力

	--★★ルーシャス★★:詫びの品を授けたのに<br>憤慨し出すとはな？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080028")

	change_face(Actor001,"Surprise")

	--★★フレン★★:…詫び？なんの
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080029")

-- ▼直接出力
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ルーシャス★★:先日、そなたらの演武に茶々を入れてしまった<br>良かれと思ったのだが…報復されてしまった
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080030")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ルーシャス★★:乙女の心の奥はいつも底知れぬ<br>ゆえに許せとは言わぬが、これで手打ちにせよ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080031")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad02")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フレン★★:…あのねェ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor005,Actor003)
SkipDefaultMotion(Actor005)
PlayActionDirect(Actor005,"to  Std_Surp")
turn_chara(Actor005,-90,0.3)
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ヴェルナルス★★:ラシア、フレンを黙らせろ
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","MA_01107_080034")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Sad")

	--★★ラシア★★:フレン、帰ろう？ね？
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01107_080036")

-- ▼直接出力
set_common_look_at(Actor005,Actor001)
PlayActionDirect(Actor005,"to Std_Loop")
turn_chara(Actor005,-103,0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★フレン★★:あのねえルーシャスくん！！
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080038")

-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Surp")
turn_chara(Actor002,140,0.3)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ローラ★★:もうやめて、お姉ちゃん～！！
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01107_080040")

	change_face(Actor001,"Normal")

	--★★フレン★★:詫びるのはこっちだよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★フレン★★:私のこと、叩いてよ
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080043")


	--★★ルーシャス★★:報復の報復を許すか<br>それも一興
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080045")

	PlayAction(Actor004,"to  Std_No")

	--★★ルーシャス★★:…だが構わぬ<br>上層に立つ者が下層民に叩かれるのは世の常だ
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080047")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
	change_face(Actor001,"Shy")

	--★★フレン★★:やっぱ、むかつく
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080049")


	--★★ルーシャス★★:持つ者が持たざる者に施すことこそ<br>君主の責務だと考えるが？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080050")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★フレン★★:…君ってもしかしてさ<br>けっこう誤解受けそうなタイプ？
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080051")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0,2.0)
PlayActionDirect(Actor001,"to LookFor")
wait_time(1.5)
PlayActionDirect(Actor001,"to Show")
wait_time(0.5)
 -- SkipDefaultMotion(Actor001)
 -- PlayActionDirect(Actor001,"to Show")
 -- wait_time(2.0)
PlayActionDirect(Actor001,"to Std_Loop")
show_image("103010370", 0.0, 0.0, 0,true,false)
fadein(1.5)
wait_time(1.5)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ルーシャス★★:…なんだこれは<br>青い鳥の羽根？
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080053")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera001)
hide_image(0)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★フレン★★:私からのお詫びの品
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★フレン★★:<ruby=それ>鳥の羽</ruby>、お守りなんだ<br>持ち主を不幸から守ってくれるんだって
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080055")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
set_common_look_at(Actor005,Actor004)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ヴェルナルス★★:ルーシャス様…いかがいたしましょうか<br>食事はあるだけ買ってしまいましたが
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","MA_01107_080057")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
change_face(Actor001,"Normal")
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ラシア★★:む無駄遣いですよ、将軍…！？
	Talk(Actor003,"CHRNAME_RASIA","speech","L","MA_01107_080058")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
	change_face(Actor005,"Sad")

	--★★ヴェルナルス★★:か、買えと言われたから…
	Talk(Actor005,"CHRNAME_VERNARTH","speech","L","MA_01107_080059")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
change_face(Actor005,"Normal")
change_face(Actor001,"Smile")
-- ▲直接出力

	--★★フレン★★:じゃあ一緒に食べる？<br>ルーシャス皇太子殿下
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080061")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ルーシャス★★:クッククク…いまさら白々しい
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080063")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★フレン★★:だね。ルーシャスくん
	Talk(Actor001,"CHRNAME_FREN","speech","L","MA_01107_080065")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ルーシャス★★:小腹がすいたな
	Talk(Actor004,"CHRNAME_LUCIUS","speech","L","MA_01107_080067")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103010370", "content_still_10301037_image", "103010370_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_02)
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
