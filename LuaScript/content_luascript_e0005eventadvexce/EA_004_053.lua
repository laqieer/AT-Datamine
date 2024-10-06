-- このluaスクリプトは、EA_004_053.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_001_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight(Actor001,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.45,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-2.3,0,-13.32})
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor005, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006, false)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor007, false)
-- ▲直接出力
-- ▼直接出力
lookobj = create_object("kara")
set_pos(lookobj,{0.005,0.976,-12.51})
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_EA_004_052_Crowds_Loop")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("101054","005","101054005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ほら、エクセリアも座って<br>一緒に食べよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530004")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor005,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor006,Actor002,"J_Head",1.0)
keep_delay_ik_lookat(Actor007,Actor002,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:でも…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530005")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
on_active(Actor003)
PlayActionDirect(Actor003,"to Wlk")
turn_lookat_position(Actor003,CharaPos110122_01_002[1],CharaPos110122_01_002[2],CharaPos110122_01_002[3],0)
slidemove(Actor003,CharaPos110122_01_002[1],CharaPos110122_01_002[2],CharaPos110122_01_002[3],2.0)
wait_time(2.0)
turn_lookat(Actor003,Actor002,0.1)
wait_time(0.1)
PlayActionDirect(Actor003,"to Std_Loop")
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1","挨拶")
-- ▲直接出力

	--★★男子生徒A★★:
	Talk(Actor003,"NPCNAME_0151","speech","N","EA_004_0530007")

-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,330,0.3)
wait_time(0.3)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:あ…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530008")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1","肯定")
-- ▲直接出力

	--★★男子生徒A★★:それから、これ美味しいよ<br>よければ、食べて
	Talk(Actor003,"NPCNAME_0151","speech","N","EA_004_0530009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:…ありがとう。嬉しいわ<br>でも、そんなに気を遣ってもらわなくても
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530010")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★男子生徒A★★:いや、これくらいしないとさ<br>俺、足引っ張っちゃってるから
	Talk(Actor003,"NPCNAME_0151","speech","N","EA_004_0530011")

-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力

	--★★ノワール★★:だから休み時間に自主練してるんだよな<br>実は努力家なんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530012")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:…そうなの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("男子1","照れ")
-- ▲直接出力

	--★★男子生徒A★★:いや、だって…<br>せっかく教えてくれてるのに悪いだろ
	Talk(Actor003,"NPCNAME_0151","speech","N","EA_004_0530014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1","肯定2")
-- ▲直接出力

	--★★男子生徒A★★:それに、エクセリアの戦術が正しいのは<br>わかってるからさ
	Talk(Actor003,"NPCNAME_0151","speech","N","EA_004_0530015")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★女子生徒A★★:ま、ちょっとレベル高すぎだけどね<br>正直私たちにはハードモード
	Talk(Actor006,"NPCNAME_0146","speech","N","EA_004_0530016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:…そうだったのね<br>そこまで無理を強いているとは気づかなかったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530017")


	--★★エクセリア★★:少しでも早く授業を切り上げられればそれだけ<br>学園祭の準備に時間を使えると思っていたけど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","落胆")
-- ▲直接出力

	--★★エクセリア★★:でもむしろあなたたちの時間を奪っていたなら<br>最適解ではなかったということね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530019")

-- ▼直接出力
PlayPartVoice("女子1","驚き")
-- ▲直接出力

	--★★女子生徒B★★:学園祭の準備って…<br>なんで、あなたがそんなこと気にするの？
	Talk(Actor007,"NPCNAME_0147","speech","N","EA_004_0530022")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:学園祭って青春なのでしょう？<br>なら、最大限楽しめたほうがいいと思って
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:青春は生徒たちの力になるものだと<br>そう、聞いたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア","悩む")
-- ▲直接出力

	--★★エクセリア★★:もしかして…だから<br>アダンは私を指揮から外したのかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530026")

	change_face(Actor001,"Normal")

	--★★ノワール★★:どうだろうな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0014")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そもそもうちのクラスがギリギリになっても<br>出し物を決めてなかっただけだし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★男子生徒B★★:そうだよ。俺たちにはちょっと<br>荷が重い戦術だったけど…
	Talk(Actor004,"NPCNAME_0153","speech","N","EA_004_0530029")


	--★★男子生徒B★★:けどエクセリアに教わった戦術が<br>最適解なのは間違いない
	Talk(Actor004,"NPCNAME_0153","speech","N","EA_004_0530030")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("女子2","肯定2")
-- ▲直接出力

	--★★女子生徒B★★:そうね。このチームだけで共有するのは<br>もったいないくらいだわ
	Talk(Actor007,"NPCNAME_0147","speech","N","EA_004_0530031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:確かにそうだな。学園の皆に知ってもらえたら<br>これからの戦いにも役に立つはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530032")


	--★★エクセリア★★:皆に知ってもらう…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530033")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat_object(Actor002,nil,"kara",0.3)
wait_time(2.5)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.4)
wait_time(0.5)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","挨拶")
-- ▲直接出力

	--★★エクセリア★★:…ねぇ、ノワール<br>クラスの出し物、まだ決まっていないのよね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あぁ。ランスロットに散々急かされてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530037")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:この授業で学んだ戦術を<br>出し物として発表するのはどうかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530039")

-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:戦術を出し物に？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エクセリア★★:そう。理論と実践は既に散々行ってきたわ<br>それをまとめて、研究成果として発表するの
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530041")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力

	--★★エクセリア★★:そうすれば、実習で上手くいかなかったことも<br>課題として昇華できるかもしれない
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:なるほど…いいかもな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530043")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子1","肯定")
-- ▲直接出力

	--★★男子生徒A★★:ああ、すごく面白いと思う！<br>けど、どうやって発表する？
	Talk(Actor003,"NPCNAME_0151","speech","N","EA_004_0530044")

-- ▼直接出力
PlayPartVoice("女子1","悩む")
-- ▲直接出力

	--★★女子生徒A★★:紙に書いて、それを貼りだすだけじゃ<br>なんか面白くないよね
	Talk(Actor006,"NPCNAME_0146","speech","N","EA_004_0530045")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("男子2","笑い")
-- ▲直接出力

	--★★男子生徒B★★:なんなら、実演してみたりするのもありかも！
	Talk(Actor004,"NPCNAME_0153","speech","N","EA_004_0530046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_EA_004_053_Whistle")
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アダン","肯定")
-- ▲直接出力

	--★★アダン★★:訓練時間終了です<br>これより、模擬戦を開始します
	Talk(Actor008,"CHRNAME_ADAM","speech","L","EA_004_0530051")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エクセリア","肯定2")
-- ▲直接出力

	--★★エクセリア★★:結局、訓練時間ぜんぶ<br>懇親会にあててしまったわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530052")

-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:けど、収穫はあっただろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:…そうね<br>最適解はひとつじゃないとわかったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","笑い")
-- ▲直接出力

	--★★ノワール★★:じゃ、その最適解を教えてくれよ<br>エクセリアの指揮でさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_004_0530055")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア","肯定")
-- ▲直接出力

	--★★エクセリア★★:…わかったわ。任せて<br>この場の最適解を、示してみせるから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","EA_004_0530056")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401005","001","401005001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401007","001","401007001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401009","001","401009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401008","001","401008001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101054","005","101054005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
