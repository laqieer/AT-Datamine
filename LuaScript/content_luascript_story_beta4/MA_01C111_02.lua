-- このluaスクリプトは、MA_01C111_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",80,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera003 = SetTemplate("Actor003",-70,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera004 = SetTemplate("Actor004",-40,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_001)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
set_pos(Actor005,{0.1,-0.09,-1})
set_rot(Actor005,{0,-175,0})
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
lookat_weight(Actor001,0.6,0.03,0.7,0)
lookat_weight(Actor002,0.5,0.03,0.7,0)
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力

	--★★ノワール★★:ハロウィン？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020002")

	PlayAction(Actor003,"to Finger")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:そう！今月のメインイベント！<br>みんなで好きな仮装をして、街を練り歩くの
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020003")

-- ▼直接出力
 --PlayPartVoice("マーリン","肯定")
-- ▲直接出力

	--★★マーリン★★:この時期は魔女の力が増すと言われています
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020004")

-- ▼直接出力
change_face(Actor003,"Normal")
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★マーリン★★:力を増した魔女から身を守るため<br>同じ魔女の格好をしてその目を欺く
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020005")


	--★★マーリン★★:そうした趣旨で始まった祭だそうです
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020006")

-- ▼直接出力
 --PlayPartVoice("ディナタン","納得")
-- ▲直接出力

	--★★ディナタン★★:そうなんだ<br>ちゃんと意味があるんですね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
-- ▲直接出力

	--★★ノワール★★:ディナタンもう大丈夫なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…うん！<br>ステージで緊張しすぎちゃったみたい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_020009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:趣旨はわかったけど…<br>このあいだ、学園祭をやったばかりじゃないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020010")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
set_enable_auto_lookat(Actor002,true)
 --PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:わたしたち、これでも一応学生なんだし<br>学生生活を楽しまないとソンでしょ？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020011")


	--★★ギネヴィア★★:どうせ気が滅入ることばっかりなんだから<br>はしゃげるときにはしゃいでおかないとね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン","肯定2")
-- ▲直接出力

	--★★マーリン★★:ええ。たとえ世界が陰鬱であったとしても<br>それに飲まれる必要はないのです
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020013")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:私もそう思うな<br>それに仮装ってなんだか楽しそう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_020014")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Surp")
turn_chara(Actor003,-40,0.3)
 --PlayPartVoice("ギネヴィア","喜び")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:でしょでしょ！
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020015")

-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Joy")
turn_chara(Actor003,-70,1)
-- ▲直接出力

	--★★ギネヴィア★★:魔女避けが仮装になっちゃうなんて<br>面白いわよね～
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020016")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat_all(false)
set_enable_auto_lookat(Actor003,true)
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C111_020017","MA_01C111_020018")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
change_face(Actor003,"Normal")
PlayActionDirect(Actor003,"to Std_Loop")
 --PlayPartVoice("ノワール","納得")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:確かにそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020020")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_enable_auto_lookat(Actor004,false)
 --PlayPartVoice("マーリン","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マーリン★★:遠い国の風習だそうですね
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020021")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:マーリンさんも仮装するつもりなんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020022")

-- ▼直接出力
 --PlayPartVoice("マーリン","悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マーリン★★:うーん、悩んではいるのですけれど<br>仮装するとしても魔女ではないものにしようかと
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
change_face(Actor003,"Normal")
PlayActionDirect(Actor003,"to Std_Loop")
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:不謹慎じゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020025")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
set_enable_auto_lookat(Actor004,false)
 --PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:えええ、いつも派手なコート着てる人が<br>そういうこと言う？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020026")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺のコートは仮装じゃない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020027")

	goto Block1end

::Block1end::
-- ▼直接出力
change_face(Actor003,"Normal")
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★マーリン★★:祭のメインイベントである魔女パレードは<br>〇日後に開催されます
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020029")

-- ▼直接出力
 --PlayPartVoice("マーリン","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マーリン★★:おふたりもぜひご参加くださいね
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:はい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
change_face(Actor004,"Normal")
set_enable_auto_lookat_all(true)
set_enable_auto_lookat(Actor004,false)
set_common_look_at(Actor003,Actor002)
 --PlayPartVoice("ギネヴィア","挨拶")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:あ…そういえば<br>ディナタン、具合は大丈夫なの？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ。もうすっかり元気みたいだ<br>なぁ、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.3)
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:うん。もうバッチリ<br>あのときは少し寝不足だったみたいです
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_020035")

-- ▼直接出力
setup_small_camera_start(Camera003)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Talk")
Appear(Actor005)
change_face(Actor001,"Normal")
change_face(Actor002,"Normal")
change_face(Actor004,"Normal")
turn_chara(Actor002,80,0)
lookat_delay_weight_reset(Actor001,1)
lookat_delay_weight_reset(Actor002,1)
lookat_delay_weight(Actor001,0.7,0.03,0.7,0,1)
lookat_delay_weight(Actor002,0.9,0.03,0.7,0,1)
 --PlayPartVoice("ギネヴィア","悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:そう？ならいいけど…<br>あんまり無理しないでね
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020036")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
PlayActionDirect(Actor005,"to Run")
slidemove(Actor005,{0.02,-0.09,-2.5},1)
wait_time(0.8)
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor003,0.7,0.03,0.7,0,1)
lookat_delay_weight(Actor004,1,0.03,0.7,0,1)
set_enable_auto_lookat_all(true)
 --PlayPartVoice("女子2","挨拶")
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:失礼します！<br>街にまた、バルバロイが！
	Talk(Actor005,"NPCNAME_0151","speech","L","MA_01C111_020037")

-- ▼直接出力
setup_small_camera_start(Camera003)
set_enable_auto_lookat_all(false)
PlayActionDirect(Actor003,"to Std_Loop")
turn_chara(Actor003,-40,1)
change_face(Actor004,"Surprise")
 --PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:またぁ！？
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01C111_020038")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
CameraEX = set_camera({-0.2347857,1.183076,-1.273934,-0.44,-178,0.036,30.36522})
setup_small_camera_start(CameraEX)
-- ▲直接出力

	--★★キャメロット騎士学術院（男）★★:はい。しかも、今回は魔女も――
	Talk(Actor005,"NPCNAME_0151","speech","L","MA_01C111_020039")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(true)
 --PlayPartVoice("マーリン","落胆")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マーリン★★:魔女も…そうですか<br>わかりました。私も参りましょう
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01C111_020040")

-- ▼直接出力
setup_small_camera_start(Camera002)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1)
PlayActionDirect(Actor002,"to  Std_Surp")
turn_chara(Actor002,180,0.3)
 --PlayPartVoice("ディナタン","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:行こう、兄さん！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_020042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera001)
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、ああ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_020043")

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
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
