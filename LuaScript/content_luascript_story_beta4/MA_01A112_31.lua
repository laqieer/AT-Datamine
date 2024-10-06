-- このluaスクリプトは、MA_01A112_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_003)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera011 = SetTemplate("Actor011",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
load_image("102030060_StillImage", "content_still_10203006_image", "102030060_StillImage")
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor009)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor010)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor011)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	Actor012 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★マーリン★★:濁水の大釜が開かんとしています<br>地は荒廃し、空は穢され
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_310002")


	--★★マーリン★★:歴史を朽ち果てさせる災厄を<br>魔女がもたらさんとしている
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_310004")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor008)
DontChangeRandomCamera(true)
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:ブリテン全域で不可解なほど爆発的な<br>バルバロイの発生が起きている…
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A112_310005")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01A112_31_Earthquake")
shake_camera(Camera008, 0.3, 2)
change_face(Actor008,"Surprise")
wait_time(1)
DontChangeRandomCamera(true)
on_camera(RndCamera090)
shake_camera(RndCamera090, 0.5, 5)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:こ、この揺れ<br>魔女が引き起こしているのか…！？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_310007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:これは余震のようなものに過ぎません<br>この余震自体もあるいは引き起こされたもの
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_310008")


	--★★マーリン★★:終わらせるつもりでいる…<br>我らがすべての備えを済ませる前に
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_310009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:備えって<br>継承者がすべき使命の…
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_310010")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:はい。聖杯を使ったバルバロイの殲滅です<br>それを叶える前に仕掛けてこようとしている
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_310011")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:…ローマより亡命してきた者たちの言葉により<br>カレドニアの現状も判明した
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A112_310012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:ルーシャスにあてがわれていた主な将校、兵…<br>そのほとんどはバルバロイに喰われ、侵蝕された
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A112_310013")


	--★★ケイ★★:魔女とバルバロイの本拠こそ<br>カレドニア城で間違いない
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A112_310014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力

	--★★ガウェイン★★:その亡命者って<br>ヴェルナルスに追われてた人らだろ？
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A112_310015")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ガウェイン★★:とっくにやられちまったと思ってたぜ
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A112_310016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:キャメリアード城の地下にて守られていたらしい<br>バルバロイから隠されるようにしてな
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A112_310017")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悲しみ")
-- ▲直接出力

	--★★ガウェイン★★:…なんの償いにもなんねーのに<br>あの人…
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A112_310018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力

	--★★マーリン★★:ルーシャスは恐らく<br>ブリテンをバルバロイで覆い尽くしたのち…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_310019")


	--★★マーリン★★:大陸および世界全土に<br>災禍をまき散らさんとするでしょう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01A112_310020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor006,"Serious")

	--★★アーサー★★:なんとしてもここで食い止める必要がある<br>素早くカレドニア城へ進撃し、ルーシャスを討つ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01A112_310021")

	open_select_window_tag(Actor003,"Normal","MA_01A112_310023","MA_01A112_310024","MA_01A112_310025")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:キズつけられた人たちのためにも<br>これで終わりにしよう
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_310027")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガウェイン★★:エレインやラヴェインに<br>景気の良い話持っていってやらねーとな
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01A112_310028")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor006,"Serious")

	--★★アーサー★★:敵も万全の態勢で挑んでくるはずだ<br>先手を打つぞ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01A112_310029")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ルーシャスに借りを返そう、ギネヴィア
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_310031")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:これ以上<br>誰かがキズつくのを見るのはまっぴらよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A112_310032")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:なんとしても<br>やってやんなきゃ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A112_310033")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ガラハッドの無念も晴らさなきゃならない
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_310035")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor007,"Normal")

	--★★ランスロット★★:…高潔な騎士にならんとしていた<br>いや、すでに騎士としては確かな腕を持っていた
	Talk(Actor007,"CHRNAME_LANCELOT","speech","L","MA_01A112_310036")

	play_head_motion(Actor009, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor009,"Sad")

	--★★ヴォールス★★:大きな損失だ<br><ruby=シルバタブラナイツ>銀卓騎士団</ruby>にとって、ブリテンにとって
	Talk(Actor009,"CHRNAME_BORS","speech","L","MA_01A112_310037")

-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "悩む")
-- ▲直接出力
	change_face(Actor010,"Sad")

	--★★パーシヴァル★★:嫌いじゃなかったな…<br>手は焼いたけどさ
	Talk(Actor010,"CHRNAME_PERCIVAL","speech","L","MA_01A112_310039")

	goto Block1end

::Block1end::
-- ▼直接出力
show_image("102030060_StillImage", 0.0, 0.0, 0.3,false,false)
-- ▲直接出力

	--★★ランスロット★★:聖杯探索班はブリテン全域の守りと<br>手薄になったコルベニック城の援護に回る
	Talk(Actor007,"CHRNAME_LANCELOT","simple","N","MA_01A112_310041")


	--★★トリスタン★★:学園の守りはボクらが
	Talk(Actor005,"CHRNAME_TRISTAN","simple","N","MA_01A112_310042")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor008)
DontChangeRandomCamera(true)
-- ▲直接出力

	--★★アーサー★★:カレドニア遠征は俺が陣頭指揮を執る
	Talk(Actor006,"CHRNAME_ARTHUR","simple","N","MA_01A112_310043")

-- ▼直接出力
hide_image(0.3)
setup_small_camera_end()
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★ケイ★★:…やはり行くのか、アーサー
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A112_310044")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー★★:座して終わりは待てない。魔女の呼び声もする<br>気苦労をかけるが…義兄さん──
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01A112_310045")

	play_head_motion(Actor008, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "笑い")
-- ▲直接出力
	change_face(Actor008,"Smile")

	--★★ケイ★★:いつものことだ<br>いつものように帰って来い
	Talk(Actor008,"CHRNAME_KAY","speech","L","MA_01A112_310046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Serious")

	--★★アーサー★★:おそらくこれがローマとの最後の戦いだ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01A112_310048")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:決着をつけよう
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01A112_310049")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:軍備が整い次第、出発の日を連絡する<br>各人、準備を怠るなよ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","MA_01A112_310051")

	open_cutin(1,1)
	on_cutin(1,Actor002,"Anger")

	--★★マーリン★★:スタンド・バイ・ユアラウンド
	Talk(Actor002,"CHRNAME_MERLIN","speech","N","MA_01A112_310052")

	close_cutin()

	--★★一同★★:フォー・ラウンド！
	Talk(Actor012,"NPCNAME_0126","speech","N","MA_01A112_310053")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102030060_StillImage", "content_still_10203006_image", "102030060_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor010")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor011")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor008,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor009,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
