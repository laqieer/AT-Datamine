-- このluaスクリプトは、MA_01B900_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_008)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110051_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_007)
	Camera009 = SetTemplate("Actor009",nil,CharaPos110051_02_020,"content_motion3d_advarea_common_adv_templatecontroller","Chr_509_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_020)
	Camera010 = SetTemplate("Actor010",nil,CharaPos110051_02_021,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_021)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor007)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor008)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_3D("101027","001","101027001","content_animationpack__common","FacialPack","Actor009")
	Actor010 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor010")
	Actor011 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:アーサーがいつかバルバロイと化すのは<br>もはや避けられぬ運命だと知らされたのだった
	Talk(Actor011,"telop","narration","N","MA_01B900_041101")


	--★★テロップ★★:
	Talk(Actor011,"telop","narration","N","MA_01B900_041102")


	--★★テロップ★★:
	Talk(Actor011,"telop","narration","N","MA_01B900_041103")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★テロップ★★:バルバロイの、王…
	Talk(Actor011,"telop","narration","N","MA_01B900_041104")

-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガラハッド★★:バルバロイの、王…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_040002")


	--★★ボールス★★:…クレアが推察していたことが<br>当たったな
	Talk(Actor007,"CHRNAME_BORS","speech","L","MA_01B900_040003")

	change_face(Actor004,"Sad")

	--★★マーリン★★:アーサー様が語った妖精ニニアンのこと<br>それもまた真実です。なぜなら──
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B900_040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フィエナ★★:今教えてくれたように<br>あなたもまた…妖精だから
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_040005")


	--★★マーリン★★:…はい
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B900_040006")

	PlayAction(Actor006,"to  Std_Angry")
	change_face(Actor006,"Anger")

	--★★フィエナ★★:だったらどうして聖杯探しのときに<br>申し出てくれなかったの！
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_040007")

	change_face(Actor008,"Surprise")

	--★★パーシヴァル★★:たしかに！<br>妖精は聖杯の場所がわかるんだろう？
	Talk(Actor008,"CHRNAME_PERCIVAL","speech","L","MA_01B900_040008")


	--★★ボールス★★:…フィエナたちをまだ疑っていたから<br>と考えるべきか？
	Talk(Actor007,"CHRNAME_BORS","speech","L","MA_01B900_040009")

	PlayAction(Actor006,"to  Std_Surp")
	change_face(Actor006,"Surprise")

	--★★フィエナ★★:ええっ！
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_040010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:聖杯探索に非協力的だったぺレス王のもとから<br>やってきたフィエナが聖杯探索を申し出た
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_040011")


	--★★ランスロット★★:誤情報で円卓を<br>陥れるつもりかもわからなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_040012")


	--★★ランスロット★★:実際…コルベニック城は<br>敵の手中だったわけだからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_041001")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor008,"Sad")

	--★★パーシヴァル★★:ま、まあ結果的に<br>１ヵ所ずつ探すハメになったし
	Talk(Actor008,"CHRNAME_PERCIVAL","speech","L","MA_01B900_040013")


	--★★パーシヴァル★★:案内役がひとりでもふたりでも<br>変わんなかったか…
	Talk(Actor008,"CHRNAME_PERCIVAL","speech","L","MA_01B900_041002")


	--★★マーリン★★:申し訳ありません、試すようなマネを…
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B900_040014")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★フィエナ★★:う、ううん！私も自分の行いが正しいのか<br>わからないでいたから…
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_040015")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Normal")

	--★★ガラハッド★★:正体を明かして危険に晒すべきではないからな<br>聖杯解放のために妖精の…力が必要なんだろう？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_040016")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★マーリン★★:はい。妖精の命が
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B900_040018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★アーサー★★:…聖杯探索に携わった者たちだけには<br>俺の血族の呪いを知っておいて欲しかった
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040020")


	--★★アーサー★★:これより来たる悲劇を回避する鍵は<br>聖杯と妖精にあるからだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040021")

	change_face(Actor008,"Normal")

	--★★パーシヴァル★★:一蓮托生ゆえの秘密の共有ってわけだね<br>まあユーサー様のことなんて大スキャンダルだし
	Talk(Actor008,"CHRNAME_PERCIVAL","speech","L","MA_01B900_040022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ボールス★★:…「アーサー王がバルバロイとなる運命だ」<br>などという報せは致命的なほど士気に関わる
	Talk(Actor007,"CHRNAME_BORS","speech","L","MA_01B900_040023")


	--★★ノワール★★:だけど…こうやって真実を明かしたということは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_040024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B900_040025","MA_01B900_040026","MA_01B900_040027")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーなりの考えがあるんだな？<br>その…『悲劇を回避する鍵』が
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_040029")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:…ああ、もちろんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_040030")

	change_face(Actor008,"Smile")

	--★★パーシヴァル★★:や、やっぱりねー！悲観する必要なし！<br>解決策があるなら早く言って欲しかったなぁ！
	Talk(Actor008,"CHRNAME_PERCIVAL","speech","L","MA_01B900_040031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_040033")

	change_face(Actor007,"Normal")

	--★★ボールス★★:どうした、ノワール
	Talk(Actor007,"CHRNAME_BORS","speech","L","MA_01B900_040034")

	change_face(Actor007,"Normal")

	--★★ボールス★★:アーサー王はこの真実を明かした、その理由は<br>明かしたとしても解決策があるからだろう
	Talk(Actor007,"CHRNAME_BORS","speech","L","MA_01B900_040035")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガラハッドやフィエナを信用してのことだな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_040037")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★マーリン★★:はい。ガラハッド様とフィエナ様がいてこそ<br>今、わずかながらの平穏があります
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B900_040038")

	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Smile")

	--★★ガラハッド★★:勝ち取った平穏のなかで<br>解決できることがあるということだな！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_040039")

	goto Block1end

::Block1end::

	--★★アーサー★★:単純かつ簡単な解決策、それはな？
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040041")


	--★★アーサー★★:オレの死だ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040042")


	--★★アーサー★★:バルバロイの王となるその前に<br>人として命を終えればいい
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040044")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★マーリン★★:そして私の命によって<br>聖杯の力の解放を行います
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","MA_01B900_040045")


	--★★アーサー★★:あとは継承者が聖域化を果たせば<br>バルバロイのいない世界平和が手に入る
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040046")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Anger")

	--★★フィエナ★★:ま、まって、よ…！聖域化には<br>ランスロットの聖遺物化が必要なんでしょ…？
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_040047")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:そのつもりで生きてきたんだ<br>俺も、アーサーもマーリン様もな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_040048")

	change_face(Actor005,"Sad")

	--★★ガラハッド★★:あ、あんまりじゃないか…！<br>せっかく平和になるのに…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_040049")


	--★★ガラハッド★★:導いてくれたあなたたちがいなくなってしまう<br>ノワールは残され、僕らはそんな世界で…
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_040050")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ガラハッド★★:笑って、暮らせるのか………？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_040051")

	PlayAction(Actor005,"to  Std_Talk")

	--★★ガラハッド★★:ガ、ガラハッドたちに<br>なにか出来ることはないのか…？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_040053")


	--★★アーサー★★:あるとも
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Angry")

	--★★フィエナ★★:私、なんでもするよ！<br>ノワールたちだけに重荷は背負わせたくないし！
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_040055")

	change_face(Actor003,"Sad")

	--★★アーサー★★:思えばここまで<br>秘密を抱え続けた者も多かった
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040056")


	--★★アーサー★★:聖杯を探しながら<br>真実を追い求めた者もいる
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040057")

	change_face(Actor003,"Normal")

	--★★アーサー★★:だが隠された本当のこと…<br>それは皆、誰かのための優しさだった
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040058")

-- ▼直接出力
se_play("SE_ADV_MA_01B900_06_HeartBeat")
-- ▲直接出力
-- ▼直接出力
wait_time(1.4)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:アーサー！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_040060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★アーサー★★:…残された時間はわずか<br>間もなくだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040061")


	--★★アーサー★★:最期にもうひとつ<br>秘密にして欲しいんだ
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040062")

	change_face(Actor001,"Normal")

	--★★ノワール★★:………それは？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_040063")


	--★★ランスロット★★:王殺しを行う
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_040064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:その真実を<br>探させないように
	Talk(Actor003,"CHRNAME_ARTHUR","speech","L","MA_01B900_040066")

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
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor008")
	InitializeCharacter_3D_Preload("101027","001","101027001","content_animationpack__common","FacialPack","Actor009")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor010")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
