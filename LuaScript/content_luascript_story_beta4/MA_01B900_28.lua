-- このluaスクリプトは、MA_01B900_28.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()


	--★★フィエナ★★:私は「聖杯へ導く妖精」の巫女<br>つまり、妖精の力の受け皿として育てられたの
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280002")


	--★★フィエナ★★:妖精が加護を施した湖に、小さい頃から身を浸し<br>擬似的な妖精の力をこの身に宿した
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280003")

	PlayAction(Actor006,"to  Std_Talk")

	--★★フィエナ★★:それは何のためだったかわかる？<br>ガラハッド
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガラハッド★★:えっ？<br>妖精がいなくなったときの保険では？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_280005")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:そう。そのための聖杯城の巫女<br>お役目が「ふたつある」って言ったの覚えてる？
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280006")


	--★★ランスロット★★:…ひとつは聖杯探索の指針となること<br>聖杯の場所を示すこと、だな？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_280007")


	--★★フィエナ★★:そのひとつ目は、妖精不在のなかで<br>バルバロイの脅威に立ち向かうための手段
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280008")


	--★★フィエナ★★:そしてふたつ目の役目は本来…<br>妖精を途絶えさせないようにするための方法
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280009")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★フィエナ★★:………妖精の身代わりとなること
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")

	--★★ガラハッド★★:姉上が、妖精の身代わり………！？
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_280012")

	change_face(Actor006,"Normal")

	--★★フィエナ★★:世界救済のために必ず妖精が<br>犠牲にならなきゃならないのを避けるために
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280013")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:つ、つまり<br>フィエナが犠牲になることで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_280014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Sad")

	--★★フィエナ★★:初めは軽い気持ちだったの<br>妖精さんの聖杯探しのお手伝い…ぐらいの
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280016")

	change_face(Actor006,"Normal")

	--★★フィエナ★★:<ruby=ふたつめ>妖精の身代わりになれる</ruby>この力は<br><ruby=ひとつめ>聖杯探知</ruby>の力を得るなか副次的に身に付いたもの
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280017")

	PlayAction(Actor006,"to  Std_No")
	change_face(Actor006,"Sad")

	--★★フィエナ★★:所詮『妖精まがい』<br>全然完璧なものじゃない
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280019")


	--★★フィエナ★★:本物の妖精の因子を借りて<br>…はじめて身代わりになれる
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280021")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★フィエナ★★:私の命で<br>サラスへの道を拓ける
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280023")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Anger")

	--★★ディナタン★★:だ、だめだよ！
	Talk(Actor003,"CHRNAME_DINATAN","speech","L","MA_01B900_280024")


	--★★フィエナ★★:あなたがいるから出来るの、ディナタン
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フィエナ★★:マーリンがいなくなった時点で<br>本当なら私たちに打つ手はなかった
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280026")


	--★★フィエナ★★:ノワールがディナタンを守り続けてくれたから<br>私がこうして役目をまっとう出来るんだよ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280027")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:…こ、こんなことのために<br>守ってきたわけじゃない…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_280028")

	open_select_window_tag(Actor001,"Normal","MA_01B900_280029","MA_01B900_280030","MA_01B900_280031")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Anger")

	--★★ノワール★★:誰も喪いたくないから──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_280033")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Normal")

	--★★フィエナ★★:私もそうだよ<br>きっと皆そうだよ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280035")

	change_face(Actor006,"Sad")

	--★★フィエナ★★:ランスロットも、ディナタンも<br>同じ気持ちなんだよ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280036")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:母さんの遺言だから──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_280038")

	change_face(Actor006,"Normal")

	--★★フィエナ★★:お母様もまた<br>妖精ニニアンのお付きだったんでしょ？
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280039")

	change_face(Actor006,"Normal")

	--★★フィエナ★★:この事態も予見してた<br>ノワールなら守り抜けると信じていた
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280040")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★フィエナ★★:平和な日々を夢見てたんだよ、きっと
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280041")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:たったひとりの家族だから──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B900_280043")

	change_face(Actor006,"Normal")

	--★★フィエナ★★:だから、身を粉にして守り抜いたんだよね<br>傭兵から…騎士となって、継承者として
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280044")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★フィエナ★★:私もたったひとりの家族を守りたいの<br>自分がどうなったとしても
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280045")

	goto Block1end

::Block1end::
	PlayAction(Actor004,"to  Std_No")
	change_face(Actor004,"Pain")

	--★★マルディサント★★:…どうしたら、せ、正解なんだよ<br>あ、あ、アタシ、なんも言えねえ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_280047")

	change_face(Actor004,"Sad")

	--★★マルディサント★★:ディーナが死ぬのはぜってー避けてえ<br>けど、それじゃあ世界が終わる
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_280048")


	--★★マルディサント★★:み、身代わりを頼みゃあ<br>当然ディーナが罪悪感でクソ苦しむ
	Talk(Actor004,"CHRNAME_MALADISANT","speech","L","MA_01B900_280049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★フィエナ★★:あなたはどうしたい？<br>ガラハッド
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280050")

	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Sad")

	--★★ガラハッド★★:あ、姉上…！<br>ガラハッドは………っ
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_280051")

	change_face(Actor006,"Sad")

	--★★フィエナ★★:私、いくじなしだったんだ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280052")


	--★★フィエナ★★:おじい様や銀卓騎士の皆の意志を聞いても<br>円卓の騎士たちの選択を目の当たりにしても
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280053")


	--★★フィエナ★★:聖杯を得た時点でこのことを私が言い出せば<br>事態はこんなに悪化しなかったんだよ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280054")


	--★★フィエナ★★:妖精マーリンも救えたはずなの<br>なのにずるずると…ずっと見過ごしてきた
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Sad01")

	--★★フィエナ★★:本当のことを言えなかった<br>怖くて、私に出来ることから逃げてたの
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280056")


	--★★ランスロット★★:死が怖くない者など…いない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","MA_01B900_280057")

	change_face(Actor006,"Normal")

	--★★フィエナ★★:けどランスロットやノワールを見て思ったの<br>多くの遺志が受け継がれているのを
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★フィエナ★★:ディナタンが死ぬのは駄目だよ<br>巻き込むものが多すぎる
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280059")

	change_face(Actor006,"Normal")

	--★★フィエナ★★:それにこれから聖域化が待つ継承者を<br>支える家族が必要だもん
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280061")


	--★★フィエナ★★:…おじい様もきっとさびしいのが辛かったんだ<br>それをノワールのお父さんが守ってくれてた
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280063")


	--★★フィエナ★★:ノワールのお父さんがおじい様に家族をくれて<br>家族はおじい様を支えてくれたんだよ
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280064")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Anger")

	--★★フィエナ★★:私も…おじい様の遺志を継ぐ<br>どんづまりの今、私にならできることがあるから
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280065")

	PlayAction(Actor005,"to  Std_Angry")

	--★★ガラハッド★★:ガ、ガラハッドはどうなるんです！<br>ガラハッドの家族はもう姉上しかいないのに！
	Talk(Actor005,"CHRNAME_GALAHAD","speech","L","MA_01B900_280066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:置いてくよ。ガラハッド
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280067")


	--★★フィエナ★★:息苦しくても生きて<br>この世界で出来る限り長く
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280069")


	--★★フィエナ★★:きっと正しい道なんてないから
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280071")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★フィエナ★★:私が命を絶てば聖遺物化される<br>皆の記憶から私の存在は消えてなくなる
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280072")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★フィエナ★★:バイブスで繋がったガラハッドと<br>継承者だけは私を記憶に留めることになる
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280073")

	change_face(Actor006,"Sad")

	--★★フィエナ★★:………だから道を選ぶ権利があるとすれば<br>ノワールとガラハッドのふたり
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280074")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Anger")

	--★★フィエナ★★:だけどお願い<br>私に…家族を護らせて
	Talk(Actor006,"CHRNAME_VIENA","speech","L","MA_01B900_280075")

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
