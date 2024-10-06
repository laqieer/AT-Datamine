-- このluaスクリプトは、MA_01108_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_SitController","to Sit01_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_002)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110011_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_508_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_007)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
set_pos(Actor006,{2.883,0,-1.208})
set_rot(Actor006,{0,256.5719,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101029","001","101029001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:着飾らせたげたわ。どうぞ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_030002")

-- ▼直接出力
on_camera(RndCamera090)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
hide_image(1.0)
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	change_face(Actor005,"Shy")

	--★★ガラハッド★★:ご、郷に入れば、とは言うが…<br>やはり、よ、鎧を返してくれないか…？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030004")

	change_face(Actor007,"Smile")

	--★★アステラ★★:学園内でさえ鎧で固めていたら威嚇行為よ<br>学ぶのなら装いからね、ガラハッド？
	Talk(Actor007,"CHRNAME_ASTERA","speech","L","MA_01108_030005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガラハッド★★:つかぬことを聞くが<br>この制服は新品か…！？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030006")

	change_face(Actor003,"Smile")

	--★★ディナタン★★:そうだよ？<br>短い期間だけどせっかくだから
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01108_030007")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:オーダーメイドよ！<br>ありがたく思いなさい！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★ガラハッド★★:な、ならいい…ならいいんだ<br>イヤ良くない！こんな心もとない布では…！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030009")

	open_select_window_tag(Actor001,"Normal","MA_01108_030011","MA_01108_030012","MA_01108_030013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:似合ってると思うな<br>さすがはギネヴィアだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_030015")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にっしっし…♪でしょお？<br>ま。採寸も発注もお姉ちゃんだけどね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_030016")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:採寸の時は大暴れするから<br>もお大変だったのよ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_030017")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:こ、こそばゆかったんだ…っ<br>触れられるのは慣れていない…！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:どう思う、ランスロット？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_030020")

	change_face(Actor004,"Normal")

	--★★ランスロット★★:ガラハッド<br>なぜ、俺をさがしていた？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01108_030021")

	change_face(Actor003,"Surprise")

	--★★ディナタン★★:ランス兄ちゃん…<br>いま気にするところがそこ…？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01108_030022")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Normal")

	--★★ランスロット★★:どう思うかと聞かれたから…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01108_030023")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:…我ら銀卓騎士団の結成は<br>あなた方に端を発しているからだ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030024")

	change_face(Actor005,"Normal")

	--★★ガラハッド★★:おさがりでないのは<br>いいものだな、ランスロット
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030026")

	change_face(Actor004,"Sad")

	--★★ランスロット★★:ガラハッド…
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01108_030028")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:アレンジはディナタンが？<br>凄く似合ってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_030030")

	change_face(Actor003,"Smile")

	--★★ディナタン★★:うんっ、お兄ちゃん<br>元の銀甲冑の意匠は残したいって言うからね
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01108_030031")

	change_face(Actor005,"Anger")

	--★★ガラハッド★★:当たり前だ！！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030032")

	change_face(Actor005,"Anger")

	--★★ガラハッド★★:ガラハッドは銀卓騎士の誇りを<br>いついかなる時も手放しはしないぞ！！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030033")

	change_face(Actor003,"Smile")

	--★★ディナタン★★:はいっ。間を取ってこうなりました～っ<br>すてきだよ、ガラハッド？
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01108_030035")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★ガラハッド★★:そうか！！ならいい！！<br>感謝する！！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030036")

	goto Block1end

::Block1end::
	change_face(Actor005,"Smile")

	--★★ガラハッド★★:…そ、そんなに似合っているというなら<br>コルベニックの皆に見せてやりたいな
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030038")

	change_face(Actor007,"Laugh")

	--★★アステラ★★:あなたのキラーズ様には<br>近い内にお披露目しないとね
	Talk(Actor007,"CHRNAME_ASTERA","speech","L","MA_01108_030039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:？<br>ガラハッドのキラーズはキミじゃないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_030040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★アステラ★★:私のマスターはコルベニック城を守護しているわ<br>ここまで私が来たのはガラハッドの護衛のため
	Talk(Actor007,"CHRNAME_ASTERA","speech","L","MA_01108_030042")


	--★★アステラ★★:ついて来て良かったわ<br>ガラハッドのキラーズには危険が過ぎるもの
	Talk(Actor007,"CHRNAME_ASTERA","speech","L","MA_01108_030043")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ガラハッド…<br>あなたのキラーズって？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_030044")

	change_face(Actor005,"Normal")

	--★★ガラハッド★★:僕の姉上──フィエナという
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ランスロット★★:フィエナ…！？
	Talk(Actor004,"CHRNAME_LANCELOT","speech","L","MA_01108_030047")


	--★★ガラハッド★★:コルベニック城の姫君<br>『聖杯城の巫女』──
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030048")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,1.0,0.5,0.3,0.5)
keep_delay_ik_lookat(Actor002,Actor005,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:聖杯城の、巫女…？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01108_030049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガラハッド★★:自慢ではないが、やんごとなき御方だ<br>みだりに城を離れられはしない
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030050")


	--★★ガラハッド★★:そしてノワール<br>お前たちの帰りを待ち望んでいる
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030051")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…フィエナ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01108_030052")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★ガラハッド★★:だからガラハッドが来たんだ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01108_030053")

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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101029","001","101029001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
