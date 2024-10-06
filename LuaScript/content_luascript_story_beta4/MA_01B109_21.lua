-- このluaスクリプトは、MA_01B109_21.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_01","110071_01_h")
Include("content_adv_advsmall_110071_01","Template110071_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",91.3,CharaPos110071_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110071_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_01,CameraPos110071_01_006)
	InitializeTemplateRandomCamera110071_01()
	InitializeTemplate110071_01()
-- ▼直接出力
load_image("MA01B1092101", "content_still_10102002_image", "101020020_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01B109_211001")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01B109_211002")


	--★★テロップ★★:
	Talk(Actor005,"telop","narration","N","MA_01B109_211003")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
 --スチル終了
CloseTalkWindow()
hide_image(1.0)
wait_time(2.4)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力

	--★★フィエナ★★:奇跡の探索隊としては<br>こぢんまりとしてるね
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:今やログレスの周りはローマ軍だらけだ<br>大部隊を動かして敵に察知されるのは避けたい
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_210003")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ローマの包囲網を抜けるには<br>少数精鋭部隊が吉、ってことね
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ガラハッド★★:…あの、大柄で物静かな人と<br>変に気取っている人は…？
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210005")


	--★★ノワール★★:ヴォールスと<br>パーシヴァルか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210006")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フィエナ★★:ソレすぐわかるのすごいけど<br>さらっと悪口を肯定してるのヤバいよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210007")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ランスロット★★:聖杯探索班を全員固めて動かすわけにはいかない<br>…正直な話をすれば──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_210008")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力

	--★★ガラハッド★★:………ガラハッドたちを信用し切れていない<br>ということだな？
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210009")


	--★★ランスロット★★:…ローマや魔女の動きを探るためにも<br>まずは俺たちが先遣隊として動こうというわけだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_210011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "気合い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:いいよ見ててよわかったよっ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210013")

	PlayAction(Actor003,"to  Std_Joy")

	--★★フィエナ★★:奇跡を呼びこんであげるから<br>『聖杯城の巫女』の名に懸けて
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210015")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ガラハッドからは聞いていたが<br>『聖杯城の巫女』って、そもそも…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:私は「聖杯へ導く妖精」の巫女<br>つまり、妖精の力の受け皿として育てられたの
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210018")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:妖精の力の受け皿？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210019")

-- ▼直接出力
CloseTalkWindow()
show_image("MA01B1092101", 0.0, 0.0, STILL_SWITCH_TIME ,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:覚えてる？聖杯城の近くに住んでたころ<br>私、よくノワールの故郷の湖で遊んでた
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_210021","MA_01B109_210022")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:もちろん覚えてるさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210024")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:俺が馬に乗って城を出ようとすると<br>目ざとく見つけて馬の背中に飛び乗ってきたな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_210025")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:いつも黙って出ていこうとするから<br>ずっと見張ってたの
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210026")

-- ▼直接出力
 --PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ディナタンも喜んでたな<br>あの頃は楽しかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210028")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだっけ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210030")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:ひどーい！<br>意地悪すると、また湖に突き落とすからね！？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210031")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:じょ、冗談だよ<br>忘れるわけないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210032")

	change_face(Actor004,"Surprise")

	--★★ガラハッド★★:（突き落とされたのか…？）
	Talk(Actor004,"CHRNAME_GALAHAD","mind","L","MA_01B109_210033")

	goto Block1end

::Block1end::
	change_face(Actor003,"Normal")

	--★★フィエナ★★:私が湖に訪れていたのも<br>巫女の役目のためなの
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210035")


	--★★フィエナ★★:妖精が加護を施した湖に、小さい頃から身を浸し<br>擬似的な妖精の力を身に宿すために
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210036")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:疑似的な妖精の力…<br>「聖杯へ導く妖精」の力がフィエナにもある…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210038")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:そう！つまり！<br>フィエナちゃんはマジ妖精ってこと！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210039")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガラハッド★★:…万一<br>妖精がいなくなってもいいようにな
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210040")

	change_face(Actor003,"Surprise")

	--★★フィエナ★★:ま、まあ、そういったときの<br>保険みたいな役割もあるよね
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210042")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:以前、聖杯の行方を聞いたとき<br>なぜそれを教えようとしなかった？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_210043")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★フィエナ★★:ぺレス王に止められてたの
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★フィエナ★★:ログレスに協力するか否かは<br>彼らの動向を見極めてからだ、って
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210046")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:バルバロイを根絶するには聖杯が必要だ<br>それはぺレス王だってわかってるはずなのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210047")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Anger")

	--★★ガラハッド★★:ログレスの連れて来たルーシャスが裏切った<br>お爺様は間違った判断をしていない
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210048")

	open_select_window_tag(Actor001,"Normal","MA_01B109_210049","MA_01B109_210050")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、どうしてガラハッドは<br>助けてくれる気になったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210052")

	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Normal")

	--★★ガラハッド★★:助けるつもりはない<br>お爺様とガラハッドは同じ気持ちだ
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210053")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガラハッド★★:だけど、お爺様の薬草採集を<br>手伝ってくれたことには感謝もしているから
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210054")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ルーシャスの裏切りは<br>ログレスにとっても想定外だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_210056")

	change_face(Actor004,"Normal")

	--★★ガラハッド★★:そうだろう<br>そう思いたい
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210057")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ガラハッド★★:想定していて止められなかったのなら<br>お前たちは手の施しようもないほど愚かだ
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210058")

	change_face(Actor004,"Normal")

	--★★ガラハッド★★:あの場でお爺様が手の内を明かさなかったのは<br>結果として正解だったと言っているんだ
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210059")

	goto Block2end

::Block2end::
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:…聖杯城の巫女の役目は、ふたつ
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210061")


	--★★フィエナ★★:ひとつは、来たるべきときが来たさいに<br>聖杯探索の指針となること
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210062")


	--★★フィエナ★★:だからせめて私の一世一代のお役目<br>果たしてみたいと思ってるの
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:おじいちゃんが唯一遺してくれた<br>私の生きる道だから
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210064")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力

	--★★ランスロット★★:聖杯に縋ろうとする<br>俺たちが言うことではないかもしれないが
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_210065")


	--★★ランスロット★★:与えられた道以外の生きかただってある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B109_210067")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:どうせならミラクル素敵な生きかたをしてみたい<br>うんっ、フィエナちゃんマジ妖精だからねっ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210068")

	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ガラハッド★★:姉上、聖杯城の巫女の役目…<br>『ふたつ』とは初耳です、ふたつ目とは…？
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210069")

-- ▼直接出力
 --PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力

	--★★フィエナ★★:ふふっ、それはヒミツ！<br>あまりにも奇跡的だからね！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210070")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ガラハッド★★:姉上、やはりガラハッドは賛成できな…
	Talk(Actor004,"CHRNAME_GALAHAD","speech","L","MA_01B109_210071")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("フィエナ", "気合い")
-- ▲直接出力

	--★★フィエナ★★:さあっ、奇跡を求めてゴー！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","MA_01B109_210073")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA01B1092101", "content_still_10102002_image", "101020020_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor004")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
