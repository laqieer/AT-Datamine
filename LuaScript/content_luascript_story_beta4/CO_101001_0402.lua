-- このluaスクリプトは、CO_101001_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_003)
	Camera002 = SetTemplate("Actor002",290,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera004 = SetTemplate("Actor004",315,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	Camera005 = SetTemplate("Actor006",nil,CharaPos110071_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_007)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
lookat_weight(Actor003,0.4,0.1,0.8,0.2)
keep_ik_lookat(Actor003,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101032","001","101032001")
	Actor006 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor006")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:今日は<br>ログレスの城下町に繰り出そうと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020002")


	--★★ノワール★★:で、いろんな店を見て回るなら<br>女子が一緒のほうがいいかと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020003")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ディナタンを連れてきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力

	--★★ディナタン★★:今日はよろしくお願いします<br>ティルフィングさん！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい<br>よろしくお願いします
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020008")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.9)
set_enable_auto_lookat(Actor003, true)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:俺は女子が好みそうな店に詳しくないから<br>ディナタン、案内を頼むよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020009")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:えっ！？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04020010")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ディナタン★★:私だって兄さんと同じタイミングでここに来たし<br>案内できるほど詳しくないよ？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04020011")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうなのか？<br>困ったな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020012")

-- ▼直接出力
 --ガレスたち登場のため,カメラ固定                                                                                                                                                                                                                                                            CloseTalkWindow()
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:土地勘ない人間だけで行って<br>迷子になるのもまずいし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020013")

-- ▼直接出力
PlayPartVoice("ガレス", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガレス2★★:あれれ～？
	Talk(Actor005,"CHRNAME_GARETH","speech","L","CO_101001_04020015")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
set_enable_auto_lookat(Actor002,false)
Appear(Actor004)
Appear(Actor006)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力


-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ガレス★★:ノワールたちじゃないか！<br>こんなところでどうしたんだ～？
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04020017")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
wait_time(0.2)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.9)
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor004,"J_Head",0.9)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,205,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
keep_delay_ik_lookat(Actor002,Actor004,"J_Head",0.9)
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★リオネス★★:さてはハラが減ってるな！？<br>そういうときはガレスに相談するといいぞ！
	Talk(Actor006,"CHRNAME_LYONESS","speech","L","CO_101001_04020018")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ありがたいけど…<br>今は特別ハラが減ってるわけじゃないんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020019")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ディナタン★★:私たち、これから<br>ログレスの城下町を巡るつもりなんですけど
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04020020")


	--★★ディナタン★★:流行りの店を知ってる人がいなくて<br>どうしようか相談してました
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04020021")

	change_face(Actor004,"Normal")

	--★★ガレス★★:なにそれ！<br>楽しそうだな～♪
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04020022")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力

	--★★リオネス★★:あたしたちも連れてけ！
	Talk(Actor006,"CHRNAME_LYONESS","speech","L","CO_101001_04020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:ログレスの町ならわたしの庭だからな♪<br>いくらでも案内できるぞ～！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04020024")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ディナタン★★:本当ですか！？<br>じゃあ、ぜひ一緒に…いいよね、兄さん？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04020025")

	open_select_window_tag(Actor001,"Normal","CO_101001_04020027","CO_101001_04020028","CO_101001_04020029")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろん構わないよ<br>よろしくな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:ガレスさん、リオネスさん<br>よろしくお願いします
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020032")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス", "肯定")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★リオネス★★:まかされたー！
	Talk(Actor006,"CHRNAME_LYONESS","speech","L","CO_101001_04020033")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",0.9)
set_enable_auto_lookat(Actor003, true)
wait_time(0.2)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:すごくいい提案だと思うんだけど<br>ティルフィングはどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:はい。私も、おふたりに<br>ご一緒していただくのが良いかと
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020036")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガレス", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ガレス★★:ばっちり<br>楽しいツアーを約束するぞ～！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","CO_101001_04020037")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.9)
-- ▲直接出力
	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:申し出は嬉しいんだけど<br>せっかくだし俺が案内したいところだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020039")

-- ▼直接出力
PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ディナタン★★:さっき自分で<br>詳しくないって言ってたじゃない
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04020040")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:マスター<br>ここはおふたりにお任せするのがよいかと
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020041")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020042")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",0.9)
wait_time(0.2)
-- ▲直接出力
	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それじゃ、思ったより人数増えちゃったけど<br>行くとしよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_04020044")

-- ▼直接出力
 --キャラ退場のため、カメラを指定
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★ディナタン★★:おー！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","CO_101001_04020045")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor003)
Hide(Actor001)
Hide(Actor004)
Camera006 = setup_small_camera_resetting(Actor006,CharaPos110071_01_001,CameraPos110071_01_001)
turn_lookat(Actor002,Actor006,0)
keep_ik_lookat(Actor002,Actor006,"J_Head")
keep_ik_lookat(Actor006,Actor002,"J_Head")
wait_time(CHARA_IN_WAIT)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("リオネス", "挨拶")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★リオネス★★:そういえば、おまえ！
	Talk(Actor006,"CHRNAME_LYONESS","speech","L","CO_101001_04020047")

-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:え？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020048")

-- ▼直接出力
PlayPartVoice("リオネス", "悩む")
-- ▲直接出力

	--★★リオネス★★:どこかであたしと会ったことあるか？
	Talk(Actor006,"CHRNAME_LYONESS","speech","L","CO_101001_04020049")

-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力

	--★★ティルフィング★★:いえ…<br>ないはず、なのですが…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020050")

	PlayAction(Actor006,"to  Std_Worry")

	--★★リオネス★★:なーんか<br>初めて会った気がしないんだよな…
	Talk(Actor006,"CHRNAME_LYONESS","speech","L","CO_101001_04020052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:…私もです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020053")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング★★:アナタを見ていると<br>不思議と懐かしい気持ちになります
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020054")

	PlayAction(Actor006,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("リオネス", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★リオネス★★:本当か！？<br>へへ、仲間だな
	Talk(Actor006,"CHRNAME_LYONESS","speech","L","CO_101001_04020056")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:…はい
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_04020058")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ティルフィング_ランクアップ4_3")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101032","001","101032001")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor006")
MobsNo = 0
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
