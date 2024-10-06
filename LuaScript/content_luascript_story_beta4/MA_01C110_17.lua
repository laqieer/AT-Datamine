-- このluaスクリプトは、MA_01C110_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor006)
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","002","101017002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","002","101033002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:抜けられた…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170002")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:どうやっても抜けられなかったのに…<br>けど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170003")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170005")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:………
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170006")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★リオネス★★:なにふたりともぼんやりしてるんだ？
	Talk(Actor005,"CHRNAME_LYONESS2","speech","L","MA_01C110_170007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？<br>ああ…いや…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170008")

	PlayAction(Actor002,"to  Std_No")

	--★★ディナタン★★:なんでもない、と思う…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170010")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マルディサント★★:ディーナたちが森を抜けられなかったのは<br>あの森に結界があったからだろうな
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170011")


	--★★マルディサント★★:おかげでアタシたちも見つけるのに苦労した
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:あの森の奥深く<br>そこに見えない壁みたいなのがあったんだ
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170013")


	--★★マルディサント★★:かすかに残ったディーナの気配を辿った先で<br>そいつをぶっ壊そうとするバルバロイを見つけて
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:…それでピンと来た<br>ディーナたちはこの先にいるってな
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
	change_face(Actor005,"Smile")

	--★★リオネス★★:バイブスとキラーズの繋がりは<br>そう簡単に断ち切れないってわけだ！
	Talk(Actor005,"CHRNAME_LYONESS2","speech","L","MA_01C110_170016")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ガレス★★:けど、ふたりはどうして<br>あんな場所にいたんだ～？
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C110_170017")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺たちは学園から飛ばされて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170018")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★マルディサント★★:あのとき、いきなり姿が消えたから<br>アタシたちもビックリしたんだ
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170019")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:あのとき…なにかあたたかいものに<br>包まれた気がしたんだけど…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:でもあの森から抜けることができなかった<br>まるで閉じ込められてるみたいに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")

	--★★ノワール★★:けど今はもう…思い出せない……
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170022")

-- ▼直接出力
change_face(Actor002, "Sad")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:どういうことだ？
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170023")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_start()
-- ▲直接出力

	--★★ガレス★★:ちょっと前から思ってたんだけど
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C110_170025")

	PlayAction(Actor004,"to  Std_Talk")

	--★★ガレス★★:な～んか君たち…雰囲気が変わったよね～<br>１ヶ月しか経ってないのに
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C110_170026")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:１ヶ月だって！？<br>もっと長い期間いた気がするけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170027")

	change_face(Actor004,"Surprise")

	--★★ガレス★★:１ヶ月だって充分長いよ！
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C110_170028")

	change_face(Actor003,"Normal")

	--★★マルディサント★★:そもそもどうやってあんな森で暮らせたんだ？<br>食い物とかイロイロ大変だったろ
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170029")

	change_face(Actor001,"Sad")

	--★★ノワール★★:それが…わからないんだ<br>俺たち、どうやって暮らしてたんだろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★マルディサント★★:はぁ？
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170031")

-- ▼直接出力
setup_small_camera_start(Camera002)
change_face(Actor002, "Sad")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ディナタンは覚えてるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170032")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…ううん。私もあんまり
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170034")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:けど、嫌な場所じゃなかった<br>閉じ込められてはいたけど、でも…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:あたたかくて<br>私たちを守ってくれてるみたいだったから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170037")


	--★★ディナタン★★:ね、兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:そう…だった気もするな<br>もうよく思い出せないけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…そっか。そうだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170044")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★マルディサント★★:…？なんか変だな、アンタら
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_170046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★リオネス★★:ともあれ学園に戻ろう！<br>あたしはおなかすいたぞ！
	Talk(Actor005,"CHRNAME_LYONESS2","speech","L","MA_01C110_170047")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:そう言われてみたら、私もちょっと…<br>森のなかでは全然お腹空かなかったのに
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_170048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな、俺もなんだかハラが減ってきた<br>…ログレスに帰らなきゃ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_170049")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor001)
Hide(Actor002)
Hide(Actor005)
Hide(Actor003)
Hide(Actor004)
Appear(Actor006)
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
setup_small_camera_end()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★モーロノエー★★:ようやく森から出てくれたのね<br>さっそく王様に伝えなくちゃ
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C110_170051")

	change_face(Actor006,"Smile")

	--★★モーロノエー★★:これでやっと、お話が動き出す
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C110_170052")


	--★★モーロノエー★★:そうでしょ、アーサー
	Talk(Actor006,"CHRNAME_SISTERS_1","speech","R","MA_01C110_170053")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","002","101017002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","002","101033002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
