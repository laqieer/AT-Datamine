-- このluaスクリプトは、MA_01104_07.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_03","110011_03_h")
Include("content_adv_advsmall_110011_03","Template110011_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_03_017,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_03_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_03_016,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_016)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_03_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_004)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_03_011,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110011_03,CameraPos110011_03_011)
	InitializeTemplateRandomCamera110011_03()
	InitializeTemplate110011_03()
-- ▼直接出力
DontChangeRandomCamera(true)
DontCameraOffset(Actor005)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	Actor009 = InitializeCharacter_TextOnly()
	Actor010 = InitializeCharacter_TextOnly()
	Actor011 = InitializeCharacter_TextOnly()
	Actor012 = InitializeCharacter_TextOnly()
	Actor013 = InitializeCharacter_TextOnly()
	Actor014 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ブレイズ★★:平和とは得やすくも奪われやすいのは<br>皆も知ってのとおりじゃが──
	Talk(Actor002,"NPCNAME_0067","speech","L","MA_01104_070002")


	--★★女子生徒A★★:本当なの？
	Talk(Actor012,"NPCNAME_0146","speech","N","MA_01104_070003")


	--★★ブレイズ★★:前王ユーサー・ペンドラゴン陛下は<br>増え続けるバルバロイに対抗するため－－
	Talk(Actor002,"NPCNAME_0067","speech","L","MA_01104_070004")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★男子生徒A★★:円卓の騎士に剣を向けた奴が<br>円卓の騎士になったって？
	Talk(Actor008,"NPCNAME_0151","speech","N","MA_01104_070005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ブレイズ★★:@－－何しろ素養のない一般人では<br>キズを負わせるのがやっとの化け物じゃから－－
	Talk(Actor002,"NPCNAME_0067","speech","L","MA_01104_070006")


	--★★女子生徒B★★:カレドニアに雇われた傭兵だったんでしょ…？
	Talk(Actor013,"NPCNAME_0147","speech","N","MA_01104_070007")


	--★★ブレイズ★★:@－－対抗できる武器を得ることのみが<br>唯一の対抗策となるわけで－－
	Talk(Actor002,"NPCNAME_0067","speech","L","MA_01104_070008")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★男子生徒B★★:傭兵団『<ruby=ラ・コート・マルタイユ>不格好なコート</ruby>』だって<br>カッコ悪ィ～
	Talk(Actor009,"NPCNAME_0153","speech","N","MA_01104_070009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:@－－ゆえに諸君らは<br>『ゲシュタルト・シフト』の会得が急務で－－
	Talk(Actor002,"NPCNAME_0067","speech","L","MA_01104_070011")


	--★★男子生徒C★★:キラーズなしじゃ<br>どうせ役立たずだろ
	Talk(Actor010,"NPCNAME_0154","speech","N","MA_01104_070012")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★ブレイズ★★:『バイブス』を覚醒させ、『キラーズ』を持つ<br>それこそがマスターとしての第一歩であり－－
	Talk(Actor002,"NPCNAME_0067","speech","L","MA_01104_070013")


	--★★男子生徒D★★:王様も何考えてんだよ…！
	Talk(Actor011,"NPCNAME_0155","speech","N","MA_01104_070014")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ブレイズ★★:これこれ、私語は－－
	Talk(Actor002,"NPCNAME_0067","speech","L","MA_01104_070015")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
set_enable_auto_lookat(Actor005,false)
lookat_weight(Actor001,0.45,0.1,0.58,0.3)
lookat_weight(Actor005,0.45,0.1,0.58,0.3)
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.7)
keep_delay_ik_lookat(Actor005,Actor003,"J_Head",0.7)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor003,"Anger")

	--★★ガウェイン★★:うるッせぇなァッッ！！
	Talk(Actor003,"CHRNAME_NAMELES","speech","N","MA_01104_070017")

	close_cutin()
-- ▼直接出力
--ガウェイン,CHRNAME_GAWAIN @名前変更
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:あー、ガウェイン、私語は──
	Talk(Actor002,"NPCNAME_0067","speech","L","MA_01104_070019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor003)
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★ガウェイン★★:先生が困ってるじゃねーか！<br>授業中にくっちゃべってよォッ！！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070020")

-- ▼直接出力
OpenFirstAppearance(Actor003)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,false)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor004,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor004,Actor003,"J_Head",0.6)
wait_time(0.2)
-- ▲直接出力

	--★★ラグネル★★:ガウェインあんただよ<br>今の原因はあんた
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_070021")

-- ▼直接出力
OpenFirstAppearance(Actor004)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
--ラグネル,CHRNAME_RAGNAR @名前変更
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor004,true)
-- ▲直接出力

	--★★ガウェイン★★:ンなことわかってる<br>でも俺はアーサー様の悪口は許せねーんだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070022")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.7)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★ガウェイン★★:言ったヤツ、立てよ<br>転校生の悪口言ったヤツは
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070024")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor005)
DontChangeRandomCamera(true)
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01104_070025","MA_01104_070026","MA_01104_070027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いいよ<br>気にしてない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_070029")

	change_face(Actor001,"Sad")

	--★★ノワール★★:みんなの心配はもっともだし<br>それに…慣れてるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_070030")

	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:（ふうん…<br>ナイーブそうに見えたけど）
	Talk(Actor005,"CHRNAME_GUINEVERE","mind","L","MA_01104_070031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()

	--★★生徒たち★★:………
	Talk(Actor014,"NPCNAME_0116","speech","N","MA_01104_070033")

	PlayAction(Actor003,"to Sit02_Talk")
	change_face(Actor003,"Serious")

	--★★ガウェイン★★:黙るくらいなら最初っから言うな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070034")

	change_face(Actor004,"Normal")

	--★★ラグネル★★:落ちついてガウェイン<br>陰口ってそういうものでしょ？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_070035")

	change_face(Actor003,"Serious")

	--★★ガウェイン★★:聞こえるよーに言いやがって<br>嫌味っつーんだよ、こういうのは
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070036")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to Sit01_RH01")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_070038")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:お前か…って、いやお前じゃねーだろ！<br>お前はお前だろ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070039")

	change_face(Actor004,"Surprise")

	--★★ラグネル★★:なんか深そうな言及
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_070040")

	goto Block1end

::Block1end::
	PlayAction(Actor003,"to Sit02_Talk")
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:オイ、転校生──…！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070042")


	--★★ガウェイン★★:俺は過去を振り返らないオトコだぜ<br>だからお前が過去になにしてようが知らねえ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070044")

	change_face(Actor003,"Serious")

	--★★ガウェイン★★:けどな、お前がもし<br>アーサー様の面目潰すようなマネすんなら…
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:容赦はしねえ<br>覚えとけ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070047")

-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:…ガウェイン<br>先生が困ってるわよ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01104_070048")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ガウェイン★★:殿下、止めないでくれよ<br>男と男の問題だぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070049")


	--★★ギネヴィア★★:その傭兵はね<br>わたしが買い上げたの
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01104_070050")

-- ▼直接出力
setup_small_camera_end()
se_play("SE_ADV_MA_01C110_42_Crowd")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:買いっ、はぁ…!?
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070052")

	open_select_window_tag(Actor001,"Normal","MA_01104_070053","MA_01104_070054")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:助けてもらった恩があるから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_070056")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:わたしが助けてもらったのよ
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01104_070057")

	change_face(Actor004,"Surprise")

	--★★ラグネル★★:ど、どっち…！？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01104_070058")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.8)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:何はともあれ<br>そういうことなの
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01104_070059")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:正式に契約した覚えはない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_070061")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:…ってことみてーだけど？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01104_070062")

-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor005,"J_Head",0.8)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ギネヴィア★★:ちょっ、えっ？<br>そ、そうなの？
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01104_070063")

	goto Block2end

::Block2end::
	change_face(Actor005,"Normal")

	--★★ギネヴィア★★:ともかく彼になにかあったら<br>容赦しないから
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01104_070065")


	--★★ギネヴィア★★:覚えといてね？
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","MA_01104_070066")

-- ▼直接出力
reserve_next_script("1章/メイン/ウレリー生徒会長代理")
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401006","001","401006001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
