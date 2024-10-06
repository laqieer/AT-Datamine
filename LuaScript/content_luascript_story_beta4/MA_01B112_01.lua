-- このluaスクリプトは、MA_01B112_01.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_01","110191_01_h")
Include("content_adv_advsmall_110191_01","Template110191_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_510_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110191_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_001)
	Camera004 = SetTemplate("Actor004",83.05,CharaPos110191_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110191_01,CameraPos110191_01_002)
	InitializeTemplateRandomCamera110191_01()
	InitializeTemplate110191_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
Hide(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115194)
	Actor001 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:………僕が『曇りなき玻璃の銀』であるものか
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010002")

	PlayAction(Actor003,"to  Std_Surp")

	--★★リリアーナ★★:…ガラハッド<br>無事、帰って来たんですね
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_010004")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ガラハッド★★:こんな僕が、甲冑しか磨けぬこんな僕がッ<br>誰の目にも止まらぬような僕が…
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★エクセリア★★:ペレス王に会ったのね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_010006")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ガラハッド★★:お爺様はガラハッドなど眼中になかった<br>その目に映っていたのは──
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★エクセリア★★:ノワールとランスロット…<br>最強騎士のふたり
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_010008")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ガラハッド★★:なぜ、あのふたりなんだ…！<br>ガラハッドはいつお爺様の目に留まる！？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★リリアーナ★★:ペレス王はあなたを<br>逃してくれたじゃないですか
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_010010")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ガラハッド★★:なぜお爺様は他の銀卓騎士と同じように<br>ガラハッドを使ってくださらなかった！？
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★エクセリア★★:…なら、ああなりたかったの？<br>同じようにバルバロイに侵されて
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_010012")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:お、お爺様が望むのなら…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010013")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Anger")

	--★★リリアーナ★★:滅多なことを言わないでください
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_010014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")

	--★★ガラハッド★★:本意だ！！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010015")

	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")

	--★★ガラハッド★★:名も、存在も、お爺様が与えてくださった<br>甲冑も！銀色も！居場所も！すべてだ！！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","N","MA_01B112_010016")

	PlayAction(Actor001,"to  Std_Surp")

	--★★ガラハッド★★:お爺様が仰せだったのだ<br>ガラハッドは『曇りなき玻璃の銀』であると！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","N","MA_01B112_010017")


	--★★ガラハッド★★:ガラハッドの道はお爺様が示してくださった！<br>お爺様の願いなら僕はなんでも聞く！なのに…！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","N","MA_01B112_010018")

	close_cutin()
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★リリアーナ★★:フィエナが…望んでいません
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_010019")


	--★★ガラハッド★★:あ、姉上も姉上だ！<br>僕の解らぬことを沢山隠している！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010020")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:姉上だって僕のことなど、どうせ──
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010021")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力

	--★★エクセリア★★:そうやって君は<br>いつまでもグズっていればいいわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_010022")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エクセリア★★:泣きつくなら姉君に
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","MA_01B112_010024")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME)
se_play("SE_ADV_MA_01B112_01_Foot_01")
wait_time(1.6)
Hide(Actor003)
Hide(Actor002)
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★リリアーナ★★:さようなら。ガラハッド
	Talk(Actor003,"CHRNAME_LILIANA","speech","L","MA_01B112_010026")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01B112_01_Foot_02")
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 1.0)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ガラハッド★★:………僕は<br>グズってなどいない
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010028")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor004,Camera004,EntryData110191_01_02,CameraAssetBundleName110191_01,CameraPos110191_01_102)
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★フィエナ★★:そうだね
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B112_010029")

	change_face(Actor001,"Normal")

	--★★ガラハッド★★:ただ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010030")


	--★★フィエナ★★:ただ？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B112_010031")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ガラハッド★★:姉上に泣きつきたいのは<br>…そうかもしれない
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010032")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★フィエナ★★:…おいで？
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B112_010033")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor001, 12.368, 0, -25.555 ,2.6)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
wait_time(1.8)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_No")
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力

	--★★ガラハッド★★:…お、お爺様が生きていたんです<br>亡くなったと思っていたのに、ね、ね、<ruby=あねうえ>姉上</ruby>ぇぇ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010035")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★フィエナ★★:そうだね
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B112_010037")


	--★★ガラハッド★★:やっと会えたんです…！なのに…！<br>僕のこと、僕のこと、見てもくれなくて…！！
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010038")


	--★★フィエナ★★:うん
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B112_010039")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
-- ▲直接出力

	--★★ガラハッド★★:姉上も、聖杯を見つけたとき…なんだか<br>ガラハッドを置いてけぼりにしそうで…っ
	Talk(Actor001,"CHRNAME_GALAHAD","speech","L","MA_01B112_010040")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:大丈夫、ごめんね<br>大丈夫だから
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B112_010041")


	--★★フィエナ★★:おじい様はあなたを玻璃の銀と言った<br>あなただけを輝かしい銀と例えた
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B112_010042")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力

	--★★フィエナ★★:ガラハッドは、愛されているよ
	Talk(Actor004,"CHRNAME_VIENA","speech","L","MA_01B112_010043")

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
	load_area_scene_preload(115194)
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101035","001","101035001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
